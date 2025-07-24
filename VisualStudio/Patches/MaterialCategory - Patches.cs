using Il2Cpp;
using UnityEngine;
using Il2CppSystem.Collections;
using MelonLoader;
using UnityEngine.UIElements;

namespace RetroTexturesMod
{
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class ClothPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.Cloth)
            {
                if (!__instance.name.StartsWith("GEAR_Cloth")) return;


            Transform root = __instance.transform;

            Transform lod1 = root.Find("Cloth_LOD1");


            if (lod1 != null)
                lod1.gameObject.SetActive(false);
            }
        }
    }
}