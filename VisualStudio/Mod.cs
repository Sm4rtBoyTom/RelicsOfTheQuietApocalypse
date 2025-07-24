using HarmonyLib;
using Il2CppAmazingAssets.TerrainToMesh;
using MelonLoader;
using RetroTexturesMod;
using UnityEngine;

namespace RetroTexturesMod
{
    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg(System.ConsoleColor.DarkYellow, "Travelling Back in Time...");
            Settings.instance.AddToModSettings("Relics of the Quiet Apocalypse");
        }
        public static bool Sceneloaded;
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (RetroTexturesUtils.IsScenePlayable(sceneName))
            {
                Sceneloaded = true;

                changeItemProperties();
            }
        }
        private static void changeItemProperties()
        {
            if (Settings.instance.Milk)
            {
                GameObject CondensedMilk = GearItem.LoadGearItemPrefab("GEAR_CondensedMilk").gameObject;
                var DisableCondensedMilkMesh = CondensedMilk.GetComponent<MeshSwapItem>();
                DisableCondensedMilkMesh.enabled = false;
            }
            if (Settings.instance.DogFood)
            {
                GameObject DogFood = GearItem.LoadGearItemPrefab("GEAR_DogFood").gameObject;
                var DisableDogFoodMesh = DogFood.GetComponent<MeshSwapItem>();
                DisableDogFoodMesh.enabled = false;
            }
            if (Settings.instance.Peaches)
            {
                GameObject CannedPeaches = GearItem.LoadGearItemPrefab("GEAR_PinnacleCanPeaches").gameObject;
                var DisableCannedPeachesMesh = CannedPeaches.GetComponent<MeshSwapItem>();
                DisableCannedPeachesMesh.enabled = false;
            }
            if (Settings.instance.Beans)
            {
                GameObject CannedBeans = GearItem.LoadGearItemPrefab("GEAR_CannedBeans").gameObject;
                var DisableCannedBeansMesh = CannedBeans.GetComponent<MeshSwapItem>();
                DisableCannedBeansMesh.enabled = false;
            }
            if (Settings.instance.TomatoSoup)
            {
                GameObject TomatoSoup = GearItem.LoadGearItemPrefab("GEAR_TomatoSoupCan").gameObject;
                var DisableTomatoSoupMesh = TomatoSoup.GetComponent<MeshSwapItem>();
                DisableTomatoSoupMesh.enabled = false;
            }
        }

    }
}

