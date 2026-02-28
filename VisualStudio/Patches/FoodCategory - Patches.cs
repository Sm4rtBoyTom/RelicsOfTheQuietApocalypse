
namespace RetroTexturesMod
{
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public static class BeefJerkyPatches
    {
        public static void Postfix(GearItem __instance)
        {
            if (__instance == null) return;

            if (__instance != null)
            {
                if (__instance.name.Contains("GEAR_BeefJerky"))
                {
                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("BeefJerky_Old");
                    Transform lod0 = root.Find("BeefJerky_LOD0");
                    Transform lod1 = root.Find("BeefJerky_LOD1");

                    if (oldMesh != null)
                        oldMesh.gameObject.SetActive(Settings.instance.BeefJerky);

                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.BeefJerky);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.BeefJerky);
                }
                if (__instance.name.Contains("GEAR_CondensedMilk"))
                {
                        Transform root = __instance.transform;

                    Transform oldMesh = root.Find("CannedFoodMesh_Old");
                    Transform lod0 = root.Find("CannedFoodMesh");
                    Transform lod1 = root.Find("OpenedMesh");

                    if (oldMesh != null)
                        oldMesh.gameObject.SetActive(Settings.instance.Milk);

                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.Milk);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.Milk);

                    if (Settings.instance.Milk == true)
                    {
                        GameManager.DestroyImmediate(__instance.GetComponent<MeshSwapItem>());
                    }
                    else return;
                }
                if (__instance.name.Contains("GEAR_DogFood"))
                {
                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("CannedFoodMesh_Old");
                    Transform lod0 = root.Find("CannedFoodMesh");
                    Transform lod1 = root.Find("OpenedMesh");

                    if (oldMesh != null)
                        oldMesh.gameObject.SetActive(Settings.instance.DogFood);

                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.DogFood);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.DogFood);

                    if (Settings.instance.DogFood == true)
                    {
                        GameManager.DestroyImmediate(__instance.GetComponent<MeshSwapItem>());
                    }
                    else return;
                }
                if (__instance.name.Contains("GEAR_PinnacleCanPeaches"))
                {
                    if (Settings.instance.Peaches_Old == true) return;
                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("OBJ_CannedFood_Old");
                    Transform lod0 = root.Find("OBJ_CannedFood");
                    Transform lod1 = root.Find("OpenedMesh");

                    if (oldMesh != null)
                        oldMesh.gameObject.SetActive(Settings.instance.Peaches);

                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.Peaches);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.Peaches);

                    if (Settings.instance.Peaches == true)
                    {
                        GameManager.DestroyImmediate(__instance.GetComponent<MeshSwapItem>());
                    }
                    else return;
                }
                if (__instance.name.Contains("GEAR_CannedBeans"))
                {
                    if (Settings.instance.Beans_Old == true) return;

                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("OBJ_CannedFood_Old");
                    Transform lod0 = root.Find("OBJ_CannedFood");
                    Transform lod1 = root.Find("OpenedMesh");

                    if (oldMesh != null)
                        oldMesh.gameObject.SetActive(Settings.instance.Beans);

                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.Beans);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.Beans);

                    if (Settings.instance.Beans == true)
                    {
                        GameManager.DestroyImmediate(__instance.GetComponent<MeshSwapItem>());
                    }
                    else return;
                }
                if (__instance.name.Contains("GEAR_TomatoSoupCan"))
                {
                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("CannedFoodMesh_Old");
                    Transform lod0 = root.Find("CannedFoodMesh");
                    Transform lod1 = root.Find("OpenedMesh");

                    if (oldMesh != null)
                        oldMesh.gameObject.SetActive(Settings.instance.TomatoSoup);

                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.TomatoSoup);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.TomatoSoup);

                    if (Settings.instance.TomatoSoup == true)
                    {
                        GameManager.DestroyImmediate(__instance.GetComponent<MeshSwapItem>());
                    }
                    else return;
                }
                if (__instance.name.Contains("GEAR_EnergyBar"))
                {
                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("CandyBarMesh_Old");
                    Transform lod0 = root.Find("CandyBarMesh_LOD0");
                    Transform lod1 = root.Find("CandyBarMesh_LOD1");

                    if (oldMesh != null)
                    {
                        oldMesh.gameObject.SetActive(Settings.instance.EnergyBar);
                        oldMesh.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
                    }
                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.EnergyBar);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.EnergyBar);
                }
                if (__instance.name.Contains("GEAR_GreenTeaPackage"))
                {
                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("OBJ_GreenTeaPackage_Old");
                    Transform lod0 = root.Find("OBJ_GreenTeaPackage_LOD0");
                    Transform lod1 = root.Find("OBJ_GreeTeaPackage_LOD1");

                    if (oldMesh != null)
                    {
                        oldMesh.gameObject.SetActive(Settings.instance.GreenTeaCup);
                        oldMesh.transform.localScale = new Vector3(1.15f, 1f, 1.15f);
                    }
                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.GreenTeaCup);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.GreenTeaCup);
                }
                if (__instance.name.Contains("GEAR_MRE"))
                {
                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("Obj_FoodMRE_Old");
                    Transform lod0 = root.Find("Obj_FoodMRE_LOD0");
                    Transform lod1 = root.Find("Obj_FoodMRE_LOD1");

                    if (oldMesh != null)
                    {
                        oldMesh.gameObject.SetActive(Settings.instance.MRE);
                        oldMesh.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                    }
                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.MRE);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.MRE);
                }
                if (__instance.name.Contains("Soda"))
                {
                    if (__instance.name == "GEAR_SodaEnergy") return;
                    if (Settings.instance.Soda_Old == true) return;

                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("FoodSodaCan_Old");
                    Transform lod0 = root.Find("FoodSodaCan_LOD0");
                    Transform lod1 = root.Find("FoodSodaCan_LOD1");

                    if (oldMesh != null)
                    {
                        oldMesh.gameObject.SetActive(Settings.instance.Soda);
                        //    oldMesh.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                    }
                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.Soda);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.Soda);
                }
                if (__instance.name.Contains("GEAR_PeanutButter"))
                {
                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("PeanutButter_Old");
                    Transform lod0 = root.Find("PeanutButter_LOD0");
                    Transform lod1 = root.Find("PeanutButter_LOD1");

                    if (oldMesh != null)
                    {
                        oldMesh.gameObject.SetActive(Settings.instance.PeanutButter);
                    }
                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.PeanutButter);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.PeanutButter);
                }
                if (__instance.name.Contains("GEAR_Crackers"))
                {
                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("OBJ_BoxedCrackers_Old");
                    Transform lod0 = root.Find("OBJ_BoxedCrackers_LOD0");
                    Transform lod1 = root.Find("OBJ_BoxedCrackers_LOD1");

                    if (oldMesh != null)
                    {
                        oldMesh.gameObject.SetActive(Settings.instance.Crackers);
                    }
                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.Crackers);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.Crackers);
                }
                if (__instance.name.Contains("GEAR_CoffeeTin"))
                {
                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("OBJ_CoffeeTin_Old");
                    Transform lod0 = root.Find("OBJ_CoffeeTin_LOD0");
                    Transform lod1 = root.Find("OBJ_CoffeeTin_LOD1");

                    if (oldMesh != null)
                    {
                        oldMesh.gameObject.SetActive(Settings.instance.CoffeeCup);
                    }
                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.CoffeeCup);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.CoffeeCup);
                }
                if (__instance.name.Contains("GEAR_CannedSardines"))
                {
                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("CannedFoodMesh_Old");
                    Transform lod0 = root.Find("CannedFoodMesh");

                    if (oldMesh != null)
                    {
                        oldMesh.gameObject.SetActive(Settings.instance.Sardines);
                    }
                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.Sardines);
                }
                if (__instance.name.Contains("GEAR_Water500ml"))
                {
                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("Water500ml_Old");
                    Transform lod0 = root.Find("Water500ml_LOD0");
                    Transform lod1 = root.Find("Water500ml_LOD1");

                    if (oldMesh != null)
                    {
                        oldMesh.gameObject.SetActive(Settings.instance.Water);
                    }

                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.Water);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.Water);
                }
                if (__instance.name.Contains("GEAR_Water1000ml"))
                {
                    Transform root = __instance.transform;

                    Transform oldMesh = root.Find("Water1000ml_Old");
                    Transform lod0 = root.Find("Water1000ml_LOD0");
                    Transform lod1 = root.Find("Water1000ml_LOD1");

                    if (oldMesh != null)
                    {
                        oldMesh.gameObject.SetActive(Settings.instance.Water);
                    }

                    if (lod0 != null)
                        lod0.gameObject.SetActive(!Settings.instance.Water);

                    if (lod1 != null)
                        lod1.gameObject.SetActive(!Settings.instance.Water);
                }
            }
        }
    }
}