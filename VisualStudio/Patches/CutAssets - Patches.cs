

namespace RetroTexturesMod
{

    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class CutAssetPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (__instance == null) return;

            string name = __instance.name;
            Transform root = __instance.transform;

            if (name.Contains("GEAR_PinnacleCanPeaches") && !Settings.instance.Peaches && !Settings.instance.Peaches_Old)
            {
                SetActive(root, "OBJ_CannedFood_Old", false);
                SetActive(root, "OBJ_CannedFood", true);
                SetActive(root, "OpenedMesh", false);
            }
            else if (name.Contains("GEAR_CannedBeans") && !Settings.instance.Beans && !Settings.instance.Beans_Old)
            {
                SetActive(root, "OBJ_CannedFood_Old", false);
                SetActive(root, "OBJ_CannedFood", true);
                SetActive(root, "OpenedMesh", false);
            }
        }
        private static void SetActive(Transform root, string childName, bool active)
        {
            Transform child = root.Find(childName);
            if (child != null) child.gameObject.SetActive(active);
        }
    }
}