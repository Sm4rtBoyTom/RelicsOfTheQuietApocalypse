using RetroTexturesMod;

namespace RetroTexturesMod;

internal static class TextureReplacementLogic
{
    private static readonly AssetBundle? retrotexturesAssetBundle =
        AssetBundleLoader.LoadBundle("RetroTextures.Assets.retrotexturesbundle");

    private static readonly Dictionary<string, Texture2D> textures = LoadTexturesFromAssetBundle();

    private static readonly HashSet<string> warnedMissing = new();

    internal static bool Ready => textures.Count > 0;

    private static Dictionary<string, Texture2D> LoadTexturesFromAssetBundle()
    {
        var loadedTextures = new Dictionary<string, Texture2D>();
        if (retrotexturesAssetBundle == null)
        {
            MelonLogger.Error("[RetroTextures] Failed to load asset bundle!");
            return loadedTextures;
        }

        foreach (var texture in retrotexturesAssetBundle.LoadAllAssets<Texture2D>())
        {
            UnityEngine.Object.DontDestroyOnLoad(texture);
            loadedTextures[texture.name] = texture;
        }

        MelonLogger.Msg($"[RetroTextures] Loaded {loadedTextures.Count} textures from bundle.");
        return loadedTextures;
    }

    // Gets a texture, re-fetching from the bundle if the Il2Cpp native object has gone dead
    private static Texture2D? GetTexture(string textureName)
    {
        if (!textures.TryGetValue(textureName, out var texture))
            return null;

        // Check the native Il2Cpp pointer — if it's zero the object was unloaded under us
        if (texture == null || texture.Pointer == IntPtr.Zero)
        {
            // Re-fetch directly from the still-alive bundle
            texture = retrotexturesAssetBundle?.LoadAsset<Texture2D>(textureName);
            if (texture != null && texture.Pointer != IntPtr.Zero)
            {
                UnityEngine.Object.DontDestroyOnLoad(texture);
                textures[textureName] = texture;
            }
            else
            {
                textures.Remove(textureName);
                return null;
            }
        }

        return texture;
    }

    internal static void SwapGearItemTexture(
        string gearName,
        string objectName,
        string textureName,
        int materialIndex = 0,
        string materialName = null)
    {
        if (!Ready) return;

        var newTexture = GetTexture(textureName);
        if (newTexture == null)
        {
       //     WarnOnce($"[RetroTextures] Missing texture '{textureName}' for gear={gearName}");
            return;
        }

        var gearItemPrefab = GearItem.LoadGearItemPrefab(gearName);
        if (gearItemPrefab == null)
        {
        //    WarnOnce($"[RetroTextures] Prefab not found for gear={gearName}");
            return;
        }

        Transform child = FindChildByNameRecursive(gearItemPrefab.transform, objectName);
        if (child == null)
        {
      //      WarnOnce($"[RetroTextures] Child '{objectName}' not found in gear={gearName}");
            return;
        }

        var renderer = child.GetComponent<MeshRenderer>();
        if (renderer == null)
        {
        //    WarnOnce($"[RetroTextures] MeshRenderer missing in gear={gearName} obj={objectName}");
            return;
        }

        var mats = renderer.sharedMaterials;
        if (mats == null || mats.Length == 0)
        {
      //      WarnOnce($"[RetroTextures] No materials in gear={gearName} obj={objectName}");
            return;
        }

        if (materialIndex == -1)
        {
            if (!string.IsNullOrEmpty(materialName))
            {
                materialIndex = FindMaterialIndexByName(mats, materialName);
                if (materialIndex == -1)
                {
                //    WarnOnce($"[RetroTextures] Material '{materialName}' not found in gear={gearName} obj={objectName}");
                    return;
                }
            }
            else materialIndex = 0;
        }

        if (materialIndex < 0 || materialIndex >= mats.Length)
        {
         //   WarnOnce($"[RetroTextures] Bad materialIndex={materialIndex} gear={gearName} obj={objectName} mats={mats.Length}");
            return;
        }

        mats[materialIndex].mainTexture = newTexture;
        renderer.sharedMaterials = mats;
    }

    private static void WarnOnce(string message)
    {
        if (warnedMissing.Add(message))
            MelonLogger.Warning(message);
    }

    private static Transform FindChildByNameRecursive(Transform root, string name)
    {
        if (root == null) return null;
        if (root.name == name) return root;

        for (int i = 0; i < root.childCount; i++)
        {
            var found = FindChildByNameRecursive(root.GetChild(i), name);
            if (found != null) return found;
        }
        return null;
    }

    private static int FindMaterialIndexByName(Material[] materials, string name)
    {
        for (int i = 0; i < materials.Length; i++)
            if (materials[i] != null && materials[i].name.Contains(name))
                return i;
        return -1;
    }

    [HarmonyPatch(typeof(Utils), nameof(Utils.GetInventoryIconTexture), new Type[] { typeof(GearItem) })]
    private static class GenericIconTextureSwap
    {
        private static bool Prefix(GearItem gi, ref Texture2D __result)
        {
            if (gi == null) return true;

            string textureName = RetroTextureSwap.GetTextureNameForGearItem(gi);
            if (string.IsNullOrEmpty(textureName)) return true;

            if (!Ready) return true;

            var newTexture = GetTexture(textureName);

            if (newTexture == null)
            {
          //      WarnOnce($"[RetroTextures] Icon texture '{textureName}' not in bundle for gi='{gi.name}'");
                return true;
            }

            __result = newTexture;
            return false;
        }
    }
}