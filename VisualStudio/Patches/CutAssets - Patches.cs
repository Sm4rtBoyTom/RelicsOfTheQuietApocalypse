using HarmonyLib;
using Il2Cpp;
using UnityEngine;
using Il2CppSystem.Collections;
using MelonLoader;
using UnityEngine.UIElements;

namespace RetroTexturesMod
{
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class Soda_OldPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.Soda == false && !Settings.instance.Soda_Old)
            {
                if (!__instance.name.StartsWith("GEAR_Soda")) return;


                Transform root = __instance.transform;

                Transform oldMesh = root.Find("FoodSodaCan_Old");
                Transform lod0 = root.Find("FoodSodaCan_LOD0");
                Transform lod1 = root.Find("FoodSodaCan_LOD1");

                if (oldMesh != null)
                    oldMesh.gameObject.SetActive(false);

                if (lod0 != null)
                    lod0.gameObject.SetActive(true);

                if (lod1 != null)
                    lod1.gameObject.SetActive(true);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class SodaGrape_OldPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.GrapeSoda == false && !Settings.instance.SodaGrape_Old)
            {
                if (!__instance.name.StartsWith("GEAR_SodaGrape")) return;


                Transform root = __instance.transform;

                Transform oldMesh = root.Find("FoodSodaCan_Old");
                Transform lod0 = root.Find("FoodSodaCan_LOD0");
                Transform lod1 = root.Find("FoodSodaCan_LOD1");

                if (oldMesh != null)
                    oldMesh.gameObject.SetActive(false);

                if (lod0 != null)
                    lod0.gameObject.SetActive(true);

                if (lod1 != null)
                    lod1.gameObject.SetActive(true);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class SodaOrange_OldPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.SodaOrange == false && !Settings.instance.SodaOrange_Old)
            {
                if (!__instance.name.StartsWith("GEAR_SodaOrange")) return;


                Transform root = __instance.transform;

                Transform oldMesh = root.Find("FoodSodaCan_Old");
                Transform lod0 = root.Find("FoodSodaCan_LOD0");
                Transform lod1 = root.Find("FoodSodaCan_LOD1");

                if (oldMesh != null)
                    oldMesh.gameObject.SetActive(false);

                if (lod0 != null)
                    lod0.gameObject.SetActive(true);

                if (lod1 != null)
                    lod1.gameObject.SetActive(true);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class Crackers_OldPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.Crackers == false && !Settings.instance.Crackers_Old)
            {
                if (!__instance.name.StartsWith("GEAR_Crackers")) return;


                Transform root = __instance.transform;

                Transform oldMesh = root.Find("OBJ_BoxedCrackers_Old");
                Transform lod0 = root.Find("OBJ_BoxedCrackers_LOD0");
                Transform lod1 = root.Find("OBJ_BoxedCrackers_LOD1");

                if (oldMesh != null)
                    oldMesh.gameObject.SetActive(false);

                if (lod0 != null)
                    lod0.gameObject.SetActive(true);

                if (lod1 != null)
                    lod1.gameObject.SetActive(true);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class MRE_OldPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.MRE == false && !Settings.instance.MRE_Old)
            {
                if (!__instance.name.StartsWith("GEAR_MRE")) return;


                Transform root = __instance.transform;

                Transform oldMesh = root.Find("Obj_FoodMRE_Old");
                Transform lod0 = root.Find("Obj_FoodMRE_LOD0");
                Transform lod1 = root.Find("Obj_FoodMRE_LOD1");

                if (oldMesh != null)
                    oldMesh.gameObject.SetActive(false);

                if (lod0 != null)
                    lod0.gameObject.SetActive(true);

                if (lod1 != null)
                    lod1.gameObject.SetActive(true);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class CoffeTin_OldPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.CoffeeCup == false && !Settings.instance.CoffeeTin_Old)
            {
                if (!__instance.name.StartsWith("GEAR_CoffeeTin")) return;


                Transform root = __instance.transform;

                Transform oldMesh = root.Find("OBJ_CoffeeTin_Old");
                Transform lod0 = root.Find("OBJ_CoffeeTin_LOD0");
                Transform lod1 = root.Find("OBJ_CoffeeTin_LOD1");

                if (oldMesh != null)
                    oldMesh.gameObject.SetActive(false);

                if (lod0 != null)
                    lod0.gameObject.SetActive(true);

                if (lod1 != null)
                    lod1.gameObject.SetActive(true);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class CannedPeaches_OldPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.Peaches == false && !Settings.instance.Peaches_Old)
            {
                if (!__instance.name.StartsWith("GEAR_PinnacleCanPeaches")) return;


                Transform root = __instance.transform;

                Transform oldMesh = root.Find("OBJ_CannedFood_Old");
                Transform lod0 = root.Find("OBJ_CannedFood");
                Transform lod1 = root.Find("OpenedMesh");

                if (oldMesh != null)
                    oldMesh.gameObject.SetActive(false);

                if (lod0 != null)
                    lod0.gameObject.SetActive(true);

                if (lod1 != null)
                    lod1.gameObject.SetActive(false);

            }
        }
    }
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class Beans_OldPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (Settings.instance.Beans == false && !Settings.instance.Beans_Old)
            {
                if (!__instance.name.StartsWith("GEAR_CannedBeans")) return;


                Transform root = __instance.transform;

                Transform oldMesh = root.Find("OBJ_CannedFood_Old");
                Transform lod0 = root.Find("OBJ_CannedFood");
                Transform lod1 = root.Find("OpenedMesh");

                if (oldMesh != null)
                    oldMesh.gameObject.SetActive(false);

                if (lod0 != null)
                    lod0.gameObject.SetActive(true);

                if (lod1 != null)
                    lod1.gameObject.SetActive(false);

            }
        }
    }

}