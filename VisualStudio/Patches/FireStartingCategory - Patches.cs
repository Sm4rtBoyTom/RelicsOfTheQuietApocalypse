using System;

namespace RetroTexturesMod
{
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class AccelerantPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (__instance == null) return;
            {
                if (__instance != null)
                {
                    if (__instance.name.Contains("GEAR_Accelerant"))
                    {
                        Transform root = __instance.transform;

                        Transform oldMesh = root.Find("Accelerant_Old");
                        Transform lod0 = root.Find("Accelerant_LOD0");
                        Transform lod1 = root.Find("Accelerant_LOD1");

                        if (oldMesh != null)
                            oldMesh.gameObject.SetActive(Settings.instance.Accelerant);

                        if (lod0 != null)
                            lod0.gameObject.SetActive(!Settings.instance.Accelerant);

                        if (lod1 != null)
                            lod1.gameObject.SetActive(!Settings.instance.Accelerant);
                    }

                    if (__instance.name.Contains("GEAR_WoodMatches"))
                    {
                        Transform root = __instance.transform;

                        Transform oldMesh = root.Find("OBJ_WoodMatches_Old");
                        Transform lod0 = root.Find("OBJ_WoodMatches_LOD0");
                        Transform lod1 = root.Find("OBJ_WoodMatches_LOD1");

                        if (oldMesh != null)
                            oldMesh.gameObject.SetActive(Settings.instance.WoodMatches);

                        if (lod0 != null)
                            lod0.gameObject.SetActive(!Settings.instance.WoodMatches);

                        if (lod1 != null)
                            lod1.gameObject.SetActive(!Settings.instance.WoodMatches);
                    }

                    if (__instance.name.Contains("GEAR_PackMatches"))
                    {
                        Transform root = __instance.transform;

                        Transform oldMesh = root.Find("OBJ_CardboardMatches_Old");
                        Transform lod0 = root.Find("OBJ_CardboardMatches_LOD0");
                        Transform lod1 = root.Find("OBJ_CardboardMatches_LOD1");

                        if (oldMesh != null)
                        {
                            oldMesh.gameObject.SetActive(Settings.instance.CardBoardMatches);
                            oldMesh.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                        }

                        if (lod0 != null)
                            lod0.gameObject.SetActive(!Settings.instance.CardBoardMatches);

                        if (lod1 != null)
                            lod1.gameObject.SetActive(!Settings.instance.CardBoardMatches);
                    }
                }
            }
        }
    }
}