using HarmonyLib;
using Il2Cpp;
using UnityEngine;
using Il2CppSystem.Collections;
using MelonLoader;
using UnityEngine.UIElements;

namespace RetroTexturesMod
{
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class BeefJerkyPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.BeefJerky)
            {
                if (!__instance.name.StartsWith("GEAR_BeefJerky")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("BeefJerky_Old");
            Transform lod0 = root.Find("BeefJerky_LOD0");
            Transform lod1 = root.Find("BeefJerky_LOD1");

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
    public static class CondensedMilkPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.Milk)
            {
                if (!__instance.name.StartsWith("GEAR_CondensedMilk")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("CannedFoodMesh_Old");
            Transform lod0 = root.Find("CannedFoodMesh");
            Transform lod1 = root.Find("OpenedMesh");

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
    public static class DogFoodPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.DogFood)
            {
                if (!__instance.name.StartsWith("GEAR_DogFood")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("CannedFoodMesh_Old");
            Transform lod0 = root.Find("CannedFoodMesh");
            Transform lod1 = root.Find("OpenedMesh");

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
    public static class CannedPeachesPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.Peaches)
            {
                if (!__instance.name.StartsWith("GEAR_PinnacleCanPeaches")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("OBJ_CannedFood_Old");
            Transform lod0 = root.Find("OBJ_CannedFood");
            Transform lod1 = root.Find("OpenedMesh");

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
    public static class CannedBeansPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.Beans)
            {
                if (!__instance.name.StartsWith("GEAR_CannedBeans")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("OBJ_CannedFood_Old");
            Transform lod0 = root.Find("OBJ_CannedFood");
            Transform lod1 = root.Find("OpenedMesh");

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
    public static class TomatoSoupPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.TomatoSoup)
            {
                if (!__instance.name.StartsWith("GEAR_TomatoSoupCan")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("CannedFoodMesh_Old");
            Transform lod0 = root.Find("CannedFoodMesh");
            Transform lod1 = root.Find("OpenedMesh");

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
    public static class EnergyBarPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.EnergyBar)
            {
                if (!__instance.name.StartsWith("GEAR_EnergyBar")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("CandyBarMesh_Old");
            Transform lod0 = root.Find("CandyBarMesh_LOD0");
            Transform lod1 = root.Find("CandyBarMesh_LOD1");

            if (oldMesh != null)
            {
                oldMesh.gameObject.SetActive(true);
                oldMesh.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
            }
            if (lod0 != null)
                lod0.gameObject.SetActive(false); 

            if (lod1 != null)
                lod1.gameObject.SetActive(false);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class HerbalTeaBoxPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.GreenTeaCup)
            {
                if (!__instance.name.StartsWith("GEAR_GreenTeaPackage")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("OBJ_GreenTeaPackage_Old");
            Transform lod0 = root.Find("OBJ_GreenTeaPackage_LOD0");
            Transform lod1 = root.Find("OBJ_GreeTeaPackage_LOD1");

            if (oldMesh != null)
            {
                oldMesh.gameObject.SetActive(true);
                oldMesh.transform.localScale = new Vector3(1.15f, 1f, 1.15f);
            }
            if (lod0 != null)
                lod0.gameObject.SetActive(false);

            if (lod1 != null)
                lod1.gameObject.SetActive(false);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class MREPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.MRE)
            {
                if (!__instance.name.StartsWith("GEAR_MRE")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("Obj_FoodMRE_Old");
            Transform lod0 = root.Find("Obj_FoodMRE_LOD0");
            Transform lod1 = root.Find("Obj_FoodMRE_LOD1");

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
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class SodaOrangePatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.SodaOrange)
            {
                if (!__instance.name.StartsWith("GEAR_SodaOrange")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("FoodSodaCan_Old");
            Transform lod0 = root.Find("FoodSodaCan_LOD0");
            Transform lod1 = root.Find("FoodSodaCan_LOD1");

            if (oldMesh != null)
            {
                oldMesh.gameObject.SetActive(true);
          //    oldMesh.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            }
            if (lod0 != null)
                lod0.gameObject.SetActive(false);

            if (lod1 != null)
                lod1.gameObject.SetActive(false);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class SodaGrapePatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.GrapeSoda)
            {
                if (!__instance.name.StartsWith("GEAR_SodaGrape")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("FoodSodaCan_Old");
            Transform lod0 = root.Find("FoodSodaCan_LOD0");
            Transform lod1 = root.Find("FoodSodaCan_LOD1");

            if (oldMesh != null)
            {
                oldMesh.gameObject.SetActive(true);
            }
            if (lod0 != null)
                lod0.gameObject.SetActive(false);

            if (lod1 != null)
                lod1.gameObject.SetActive(false);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class SodaPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.Soda)
            {
                if (!__instance.name.StartsWith("GEAR_Soda")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("FoodSodaCan_Old");
            Transform lod0 = root.Find("FoodSodaCan_LOD0");
            Transform lod1 = root.Find("FoodSodaCan_LOD1");

            if (oldMesh != null)
            {
                oldMesh.gameObject.SetActive(true);
            }
            if (lod0 != null)
                lod0.gameObject.SetActive(false);

            if (lod1 != null)
                lod1.gameObject.SetActive(false);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class PeanutButterPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.PeanutButter)
            {
                if (!__instance.name.StartsWith("GEAR_PeanutButter")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("PeanutButter_Old");
            Transform lod0 = root.Find("PeanutButter_LOD0");
            Transform lod1 = root.Find("PeanutButter_LOD1");

            if (oldMesh != null)
            {
                oldMesh.gameObject.SetActive(true);
            }
            if (lod0 != null)
                lod0.gameObject.SetActive(false);

            if (lod1 != null)
                lod1.gameObject.SetActive(false);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class CrackersPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.Crackers)
            {
                if (!__instance.name.StartsWith("GEAR_Crackers")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("OBJ_BoxedCrackers_Old");
            Transform lod0 = root.Find("OBJ_BoxedCrackers_LOD0");
            Transform lod1 = root.Find("OBJ_BoxedCrackers_LOD1");

            if (oldMesh != null)
            {
                oldMesh.gameObject.SetActive(true);
            }
            if (lod0 != null)
                lod0.gameObject.SetActive(false);

            if (lod1 != null)
                lod1.gameObject.SetActive(false);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class CoffeeTinPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.CoffeeCup)
            {
                if (!__instance.name.StartsWith("GEAR_CoffeeTin")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("OBJ_CoffeeTin_Old");
            Transform lod0 = root.Find("OBJ_CoffeeTin_LOD0");
            Transform lod1 = root.Find("OBJ_CoffeeTin_LOD1");

            if (oldMesh != null)
            {
                oldMesh.gameObject.SetActive(true);
            }
            if (lod0 != null)
                lod0.gameObject.SetActive(false);

            if (lod1 != null)
                lod1.gameObject.SetActive(false);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class SardinesPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.Sardines)
            {
                if (!__instance.name.StartsWith("GEAR_CannedSardines")) return;


            Transform root = __instance.transform;

            Transform oldMesh = root.Find("CannedFoodMesh_Old");
            Transform lod0 = root.Find("CannedFoodMesh");

            if (oldMesh != null)
            {
                oldMesh.gameObject.SetActive(true);
            }
            if (lod0 != null)
                lod0.gameObject.SetActive(false);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class Water500mlPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.Water)
            {
                if (!__instance.name.StartsWith("GEAR_Water500ml")) return;

                Transform root = __instance.transform;

                Transform oldMesh = root.Find("Water500ml_Old");
                Transform lod0 = root.Find("Water500ml_LOD0");
                Transform lod1 = root.Find("Water500ml_LOD1");

                if (oldMesh != null)
                {
                    oldMesh.gameObject.SetActive(true);
                }

                if (lod0 != null)
                    lod0.gameObject.SetActive(false);

                if (lod1 != null)
                    lod1.gameObject.SetActive(false);
            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class Water1000mlPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.Water)
            {
                if (!__instance.name.StartsWith("GEAR_Water1000ml")) return;

                Transform root = __instance.transform;

                Transform oldMesh = root.Find("Water1000ml_Old");
                Transform lod0 = root.Find("Water1000ml_LOD0");
                Transform lod1 = root.Find("Water1000ml_LOD1");

                if (oldMesh != null)
                {
                    oldMesh.gameObject.SetActive(true);
                }

                if (lod0 != null)
                    lod0.gameObject.SetActive(false);

                if (lod1 != null)
                    lod1.gameObject.SetActive(false);
            }
        }
    }

}