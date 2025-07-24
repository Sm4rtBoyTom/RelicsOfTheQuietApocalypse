using System;

namespace RetroTexturesMod
{
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
public static class AccelerantPatches
{
    public static void Postfix(GearItem __instance)
    {
            if (Settings.instance.Accelerant)
            {
                if (!__instance.name.StartsWith("GEAR_Accelerant")) return;
        

            Transform root = __instance.transform;

        Transform oldMesh = root.Find("Accelerant_Old");
        Transform lod0 = root.Find("Accelerant_LOD0");
        Transform lod1 = root.Find("Accelerant_LOD1");

        if (oldMesh != null)
            oldMesh.gameObject.SetActive(true);

        if (lod0 != null)
            lod0.gameObject.SetActive(false);

        if (lod1 != null)
            lod1.gameObject.SetActive(false);
            }
        }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class WoodMatchesPatches
    {
        public static void Postfix(GearItem __instance)
        {
                if (Settings.instance.WoodMatches)
                {
                    if (!__instance.name.StartsWith("GEAR_WoodMatches")) return;

                Transform root = __instance.transform;

            Transform oldMesh = root.Find("OBJ_WoodMatches_Old");
            Transform lod0 = root.Find("OBJ_WoodMatches_LOD0");
            Transform lod1 = root.Find("OBJ_WoodMatches_LOD1");

            if (oldMesh != null)
                oldMesh.gameObject.SetActive(true);

            if (lod0 != null)
                lod0.gameObject.SetActive(false);

            if (lod1 != null)
                lod1.gameObject.SetActive(false);
                }
            }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class CardboardMatchesPatches
    {
        public static void Postfix(GearItem __instance)
        {
                if (Settings.instance.CardBoardMatches)
                {
                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("OBJ_CardboardMatches_Old");
                    Transform lod0 = root.Find("OBJ_CardboardMatches_LOD0");
                    Transform lod1 = root.Find("OBJ_CardboardMatches_LOD1");

                    if (oldMesh != null)
                    {
                        oldMesh.gameObject.SetActive(true);
                        oldMesh.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                    }

                    if (lod0 != null)
                        lod0.gameObject.SetActive(false);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(false);
                } 
        }
    }
}
}