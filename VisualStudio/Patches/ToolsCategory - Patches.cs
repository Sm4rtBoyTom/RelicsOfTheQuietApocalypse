using System;

namespace RetroTexturesMod
{
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class PrybarPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (__instance == null) return;

            if (__instance != null)
            {
                if (__instance.name.Contains("GEAR_Prybar"))
                {
                    Transform root = __instance.transform;

                    Transform lod1 = root.Find("OBJ_PryBar_LOD1");

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.Prybar);
                }
                if (__instance.name.Contains("GEAR_Cloth"))
                {
                    Transform root = __instance.transform;

                    Transform lod1 = root.Find("Cloth_LOD1");

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.Cloth);
                }
            }
        }
    }
}
