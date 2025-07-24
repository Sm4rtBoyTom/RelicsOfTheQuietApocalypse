using RetroTexturesMod;

namespace RetroTexturesMod;

internal class RetroTextureSwap
{
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Deserialize))]
    private static class ReplaceTextures
    {
        private static void Postfix()
        {
            if (Settings.instance.Accelerant)  //Firestarting Category
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_Accelerant", "Accelerant_Old", "GEAR_Accelerant_Dif", 0);
            }
            if (Settings.instance.WoodMatches)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_WoodMatches", "OBJ_WoodMatches_Old", "GEAR_MatchesFlare_Dif", 0);
            }
            if (Settings.instance.CatTailTinder)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_CatTailTinder", "CattailTinder_LOD0", "GEAR_CatTailTinder_Dif", 0);
            }

            if (Settings.instance.Book)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BookA", "BookA_LOD0", "GEAR_BookA_Dif", 0);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BookB", "BookB_LOD0", "GEAR_BookA_Dif", 0);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BookBopen", "BookBopen_LOD0", "GEAR_BookA_Dif", 0);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BookC", "BookC_LOD0", "GEAR_BookA_Dif", 0);
            }
            if (Settings.instance.HydrogenPeroxide) //FirstAid Category
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BottleHydrogenPeroxide", "BottleHydrogenPeroxide_LOD0", "GEAR_HydrogenPeroxide_Dif", 0);
            }
            if (Settings.instance.PainKillers)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BottlePainKillers", "BottlePainKillers_LOD0", "GEAR_BottlePainKillers_Dif", 0);
            }
            if (Settings.instance.ReishiTea)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_ReishiTea", "ReishiTea_LOD0", "GEAR_ReishiTeaCup_Dif", 0);
            }
            if (Settings.instance.RosehipTea)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_RoseHipTea", "RoseHipTea_LOD0", "GEAR_RosehipTeaCup_Dif", 0);
            }
            if (Settings.instance.WaterTablets)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_WaterPurificationtablets", "WaterPurificationTablets_LOD0", "GEAR_WaterPurificationTablets_Dif", 0);
            }
            if (Settings.instance.BeefJerky)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BeefJerky", "BeefJerky_Old", "GEAR_BeefJerky_Dif", 0);
            }
            if (Settings.instance.CandyBar)
            {
               TextureReplacementLogic1.SwapGearItemTexture("GEAR_CandyBar", "CandyBarMesh", "GEAR_CandyBar_Dif", 0);
            }
            if (Settings.instance.CattailStalk)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_CattailStalk", "CattailStalkMesh", "GEAR_CattailStalk_Dif", 0);
            }
            if (Settings.instance.Milk)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_CondensedMilk", "CannedFoodMesh_Old", "GEAR_CondensedMilk_Dif", 0);
            }
            if (Settings.instance.CoffeeCup)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_CoffeeCup", "Mesh", "GEAR_CoffeeCup_Dif", 0);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_CoffeeTin", "OBJ_CoffeeTin_Old", "GEAR_CoffeeTin_Dif", 0);
            }
            if (Settings.instance.GreenTeaCup)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_GreenTeaCup", "Mesh", "GEAR_GreenTeaCup_Dif", 0);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_GreenTeaPackage", "OBJ_GreenTeaPackage_Old", "GEAR_GreenTeaPackage_Dif", 0);
            }
            if (Settings.instance.DogFood)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_Dogfood", "CannedFoodMesh_Old", "GEAR_DogFood_Dif", 0);
            }
            if (Settings.instance.EnergyBar)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_EnergyBar", "CandyBarMesh_Old", "GEAR_EnergyBar_Dif", 0);
            }
            if (Settings.instance.GranolaBar)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_GranolaBar", "GranolaBarMesh", "GEAR_GranolaBar_Dif", 0);
            }
            if (Settings.instance.MRE)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_MRE", "Obj_FoodMRE_Old", "GEAR_MRE_Dif", 0);
            }
            if (Settings.instance.SodaOrange)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_SodaOrange", "FoodSodaCan_Old", "GEAR_SodaOrange_Dif", 0);
            }
            if (Settings.instance.PeanutButter)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_PeanutButter", "PeanutButter_Old", "GEAR_PeanutButter_Dif", 0);
            }
            if (Settings.instance.Peaches)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_PinnacleCanPeaches", "OBJ_CannedFood_Old", "GEAR_PinnacleCanPeaches_Dif", 0);
            }
            if (Settings.instance.Beans)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_CannedBeans", "OBJ_CannedFood_Old", "GEAR_CannedBeans_Dif", 0);
            }
            if (Settings.instance.Crackers)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_Crackers", "OBJ_BoxedCrackers_Old", "GEAR_Crackers_Dif", 0);
            }
            if (Settings.instance.GrapeSoda)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_SodaGrape", "FoodSodaCan_Old", "GEAR_SodaGrape_Dif", 0);
            }
            if (Settings.instance.Soda)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_Soda", "FoodSodaCan_Old", "GEAR_Soda_Dif", 0);
            }
            if (Settings.instance.Sardines)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_CannedSardines", "CannedFoodMesh_Old", "GEAR_CannedSardines_Dif", 0);
            }
            if (Settings.instance.TomatoSoup)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_TomatoSoupCan", "CannedFoodMesh_Old", "GEAR_TomatoSoupCan_Dif", 0);
            }
            if (Settings.instance.BearSkinBedroll) //Tools Category
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BearSkinBedRoll", "BedRollMesh", "GEAR_BearSkinBedRoll_Dif", 0);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BearSkinBedRoll", "BedRollPlacedMesh", "GEAR_BearSkinBedRoll_Dif", 0);
            }
            if (Settings.instance.Bedroll)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BedRoll", "BedRollMesh", "GEAR_BedRoll_Dif", 0);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BedRoll", "BedRollPlacedMesh", "GEAR_BedRoll_Dif", 0);
            }
            if (Settings.instance.CanOpener)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_CanOpener", "OBJ_CanOpener", "GEAR_CanOpener_Dif", 0);
            }
            if (Settings.instance.Hatchet)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_Hatchet", "OBJ_Hatchet", "GEAR_Hatchet_Dif", 0);
            }
            if (Settings.instance.JerryCan)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_JerrycanRusty", "JerrycanRusty_LOD0", "GEAR_Jerrycan_Dif", 0);
            }
            if (Settings.instance.LampFuel)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_LampFuelFull", "LampFuel_LOD0", "GEAR_LampFuel_Dif", 0);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_LampFuel", "LampFuel_LOD0", "GEAR_LampFuel_Dif", 0);
            }
            if (Settings.instance.Prybar)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_Prybar", "OBJ_PryBar_LOD0", "GEAR_PryBar_Dif", 0);
            }
            if (Settings.instance.Tools)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_SimpleTools", "SimpleTools_LOD0", "GEAR_SimpleTools_Dif", 0);
            }
            if (Settings.instance.SewingKit)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_SewingKit", "SewingKitMesh", "GEAR_SewingKit_Dif", 0);
            }
            if (Settings.instance.Cloth)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_Cloth", "Cloth_LOD0", "GEAR_Cloth_Dif", 0);
            }
            if (Settings.instance.Reishi)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_ReishiMushroom", "ReishiMushroom_LOD0", "GEAR_ReishiMushroom_Dif", 0);
            }
            if (Settings.instance.Rosehip)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_RoseHip", "RoseHip_LOD0", "GEAR_RoseHip_Dif", 0);
            }
            if (Settings.instance.HarvestBook) //Research Books
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BookCarcassHarvesting", "Mesh", "GEAR_BookCarcassHarvesting_Dif", 1);
            }
            if (Settings.instance.GunBook)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BookRifleFirearm", "Mesh", "GEAR_BookRifleFirearm_Dif", 0);
            }
            if (Settings.instance.CookingBook)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BookCooking", "Mesh", "GEAR_BookCooking_Dif", 1);
            }
            if (Settings.instance.IceFishing)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BookIceFishing", "Mesh", "GEAR_BookIceFishing_Dif", 0);
            }
            if (Settings.instance.FireBook)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BookFireStarting", "Mesh", "GEAR_BookFireStarting_Dif", 1);
            }
            if (Settings.instance.GunsAdvanced)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_BookRifleFirearmAdvanced", "Mesh", "GEAR_BookRifleFirearmAdvanced_Dif", 0);
            }
            if (Settings.instance.Soda_Old) // Cut Content
            {
                TextureReplacementLogic1  .SwapGearItemTexture("GEAR_Soda", "FoodSodaCan_LOD0", "GEAR_FoodSodaSummitCut_Dif", 1);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_Soda", "FoodSodaCan_LOD1", "GEAR_FoodSodaSummitCut_Dif", 1);
            }
            if (Settings.instance.SodaGrape_Old)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_SodaGrape", "FoodSodaCan_LOD0", "GEAR_FoodSodaGrapeCut_Dif", 1);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_SodaGrape", "FoodSodaCan_LOD1", "GEAR_FoodSodaGrapeCut_Dif", 1);
            }
            if (Settings.instance.SodaOrange_Old)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_SodaOrange", "FoodSodaCan_LOD0", "GEAR_FoodSodaOrangeCut_Dif", 1);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_SodaOrange", "FoodSodaCan_LOD1", "GEAR_FoodSodaOrangeCut_Dif", 1);
            }
            if (Settings.instance.CoffeeTin_Old)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_CoffeeTin", "OBJ_CoffeeTin_LOD0", "GEAR_CoffeeTinCut_Dif", 0);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_CoffeeTin", "OBJ_CoffeeTin_LOD1", "GEAR_CoffeeTinCut_Dif", 0);
            }
            if (Settings.instance.Crackers_Old)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_Crackers", "OBJ_BoxedCrackers_LOD0", "GEAR_BoxedCrackersCut_Dif", 0);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_Crackers", "OBJ_BoxedCrackers_LOD1", "GEAR_BoxedCrackersCut_Dif", 0);
            }
            if (Settings.instance.MRE_Old)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_MRE", "Obj_FoodMRE_LOD0", "GEAR_FoodMRECut_Dif", 0);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_MRE", "Obj_FoodMRE_LOD1", "GEAR_FoodMRECut_Dif", 0);
            }
            if (Settings.instance.Peaches_Old)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_PinnacleCanPeaches", "OBJ_CannedFood", "GEAR_FoodCannedPeachesCut_Dif", 0);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_PinnacleCanPeaches", "OBJ_CannedBeansUsed", "GEAR_FoodCannedPeachesCut_Dif", 1);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_PinnacleCanPeaches", "OpenedMesh/OBJ_CannedBeansUsed", "GEAR_FoodCannedPeachesCut_Dif", 1);
            }
            if (Settings.instance.Beans_Old)
            {
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_CannedBeans", "OBJ_CannedFood", "GEAR_FoodPorkAndBeansCut_Dif", 0);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_CannedBeans", "OBJ_CannedBeansUsed", "GEAR_FoodPorkAndBeansCut_Dif", 1);
                TextureReplacementLogic1.SwapGearItemTexture("GEAR_CannedBeans", "OpenedMesh/OBJ_CannedBeansUsed", "GEAR_FoodPorkAndBeansCut_Dif", 1);

            }
        }
    }
    internal static string GetTextureNameForGearItem(GearItem gi)
    {
        var textureMapping = new Dictionary<string, string>
            {
                
             { "GEAR_Accelerant", "ico_GearItem__Accelerant" }, //Firestarting Category
             { "GEAR_WoodMatches", "ico_GearItem__WoodMatches" },
             { "GEAR_CattailTinder", "ico_GearItem__CattailTinder" },
             { "GEAR_BookA", "ico_GearItem__Book" },
             { "GEAR_BookB", "ico_GearItem__Book" },
             { "GEAR_BookBopen", "ico_GearItem__Book" },
             { "GEAR_BookC", "ico_GearItem__Book" },
             { "GEAR_PackMatches", "ico_GearItem__PackMatches" },
             { "GEAR_BottleHydrogenPeroxide", "ico_GearItem__BottleHydrogenPeroxide" }, //First Aid Category
             { "GEAR_BottlePainKillers", "ico_GearItem__BottlePainKillers" },
             { "GEAR_ReishiTea", "ico_GearItem__ReishiTea" },
             { "GEAR_RoseHipTea", "ico_GearItem__RoseHipTea" },
             { "GEAR_WaterPurificationTablets", "ico_GearItem__WaterPurificationTablets" },
             { "GEAR_BeefJerky", "ico_GearItem__BeefJerky" }, //Food&Drink Category
             { "GEAR_CandyBar", "ico_GearItem__CandyBar" },
             { "GEAR_CattailStalk", "ico_GearItem__CattailStalk" },
             { "GEAR_CondensedMilk", "ico_GearItem__CondensedMilk" },
             { "GEAR_CoffeeCup", "ico_GearItem__CoffeeCup" },
             { "GEAR_GreenTeaCup", "ico_GearItem__GreenTeaCup" },
             { "GEAR_DogFood", "ico_GearItem__DogFood" },
             { "GEAR_EnergyBar", "ico_GearItem__EnergyBar" },
             { "GEAR_GranolaBar", "ico_GearItem__GranolaBar" },
             { "GEAR_GreenTeaPackage", "ico_GearItem__GreenTeaPackage" },
             { "GEAR_MRE", "ico_GearItem__MRE" },
             { "GEAR_SodaOrange", "ico_GearItem__SodaOrange" },
             { "GEAR_PeanutButter", "ico_GearItem__PeanutButter" },
             { "GEAR_PinnacleCanPeaches", "ico_GearItem__PinnacleCanPeaches" },
             { "GEAR_CannedBeans", "ico_GearItem__CannedBeans" },
             { "GEAR_Crackers", "ico_GearItem__Crackers" },
             { "GEAR_SodaGrape", "ico_GearItem__SodaGrape" },
             { "GEAR_Soda", "ico_GearItem__Soda" },
             { "GEAR_CoffeeTin", "ico_GearItem__CoffeeTin" },
             { "GEAR_CannedSardines", "ico_GearItem__CannedSardines" },
             { "GEAR_TomatoSoupCan", "ico_GearItem__TomatoSoup" },
             { "GEAR_WaterSupplyPotable", "ico_GearItem__WaterSupplyPotable" },
             { "GEAR_WaterSupplyNotPotable", "ico_GearItem__WaterSupplyNotPotable" },
             { "GEAR_Water500ml", "ico_GearItem__Water500ml" },
             { "GEAR_Water1000ml", "ico_GearItem__Water1000ml" },
             { "GEAR_BearSkinBedRoll", "ico_GearItem__BearSkinBedroll" }, //Tools Category
             { "GEAR_BedRoll", "ico_GearItem__BedRoll" },
             { "GEAR_CanOpener", "ico_GearItem__CanOpener" },
             { "GEAR_Hatchet", "ico_GearItem__Hatchet" },
             { "GEAR_JerrycanRusty", "ico_GearItem__JerrycanRusty" },
             { "GEAR_LampFuelFull", "ico_GearItem__LampFuel" },
             { "GEAR_LampFuel", "ico_GearItem__LampFuel" },
             { "GEAR_Prybar", "ico_GearItem__Prybar" },
             { "GEAR_SewingKit", "ico_GearItem__SewingKit" },
             { "GEAR_SimpleTools", "ico_GearItem__SimpleTools" },
             { "GEAR_Cloth", "ico_GearItem__Cloth" }, //Material Category
             { "GEAR_ReishiMushroom", "ico_GearItem__ReishiMushroom" },
             { "GEAR_RoseHip", "ico_GearItem__RoseHip" },
             { "GEAR_BookCarcassHarvesting", "ico_GearItem__BookCarcassHarvesting" }, //SkillBooks Category
             { "GEAR_BookCooking", "ico_GearItem__BookCooking" },
             { "GEAR_BookRifleFirearm", "ico_GearItem__BookRifleFirearm" },
             { "GEAR_BookRifleFirearmAdvanced", "ico_GearItem__BookRifleFirearmAdvanced" },
             { "GEAR_BookFireStarting", "ico_GearItem__BookFireStarting" },
             { "GEAR_BookIceFishing", "ico_GearItem__BookIceFishing" },                                                       
            };

        if (gi.name == "GEAR_Accelerant" && !Settings.instance.Accelerant) // Firestarting Category
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_WoodMatches" && !Settings.instance.WoodMatches)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_CattailTinder" && !Settings.instance.CatTailTinder)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_BookA" && !Settings.instance.Book)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_BookB" && !Settings.instance.Book)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_BookBopen" && !Settings.instance.Book)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_BookC" && !Settings.instance.Book)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_PackMatches" && !Settings.instance.CardBoardMatches)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_BottleHydrogenPeroxide" && !Settings.instance.HydrogenPeroxide)//First Aid Category
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_BottlePainKillers" && !Settings.instance.PainKillers)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_ReishiTea" && !Settings.instance.ReishiTea)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_RoseHipTea" && !Settings.instance.RosehipTea)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_WaterPurificationTablets" && !Settings.instance.WaterTablets)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_Beefjerky" && !Settings.instance.BeefJerky)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_CandyBar" && !Settings.instance.CandyBar)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_CatitailStalk" && !Settings.instance.CattailStalk)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_CondensedMilk" && !Settings.instance.Milk)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_CoffeeCup" && !Settings.instance.CoffeeCup)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_GreenTeaCup" && !Settings.instance.GreenTeaCup)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_DogFood" && !Settings.instance.DogFood)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_EnergyBar" && !Settings.instance.EnergyBar)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_GranolaBar" && !Settings.instance.GranolaBar)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_GreenTeaPackage" && !Settings.instance.GreenTeaCup)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_PeanutButter" && !Settings.instance.PeanutButter)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_CannedSardines" && !Settings.instance.Sardines)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_TomatoSoupCan" && !Settings.instance.TomatoSoup)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_WaterSupplyPotable" && !Settings.instance.Water)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_WaterSupplyNotPotable" && !Settings.instance.Water)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_Water500ml" && !Settings.instance.Water)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_Water1000ml" && !Settings.instance.Water)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_BearSkinBedRoll" && !Settings.instance.BearSkinBedroll) // Tools Category
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_BedRoll" && !Settings.instance.Bedroll)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_CanOpener" && !Settings.instance.CanOpener)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_Hatchet" && !Settings.instance.Hatchet)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_JerrycanRusty" && !Settings.instance.JerryCan)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_LampFuel" && !Settings.instance.LampFuel)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_Prybar" && !Settings.instance.Prybar)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_SewingKit" && !Settings.instance.SewingKit)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_SimpleTools" && !Settings.instance.Tools)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_ReishiMushroom" && !Settings.instance.Reishi)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_RoseHip" && !Settings.instance.Rosehip)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_BookCooking" && !Settings.instance.CookingBook) //Research Books
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_BookCarcassHarvesting" && !Settings.instance.HarvestBook)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_BookIceFishing" && !Settings.instance.IceFishing)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_BookRifleFirearm" && !Settings.instance.GunBook)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_BookFireStarting" && !Settings.instance.FireBook)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_BookRifleFirearmAdvanced" && !Settings.instance.GunsAdvanced)
        {
            return string.Empty;
        }
        if (gi.name == "GEAR_CannedBeans")
        {
            if (!Settings.instance.Beans && !Settings.instance.Beans_Old)
                return string.Empty;

            if (Settings.instance.Beans && Settings.instance.Beans_Old)
                return string.Empty;

            if (!Settings.instance.Beans && Settings.instance.Beans_Old)
                return "ico_GearItem__CannedBeans_Old";

            if (Settings.instance.Beans && !Settings.instance.Beans_Old)
                return "ico_GearItem__CannedBeans";
        }
        if (gi.name == "GEAR_PinnacleCanPeaches")
        {
            if (!Settings.instance.Peaches && !Settings.instance.Peaches_Old)
                return string.Empty;

            if (Settings.instance.Peaches && Settings.instance.Peaches_Old)
                return string.Empty;

            if (!Settings.instance.Peaches && Settings.instance.Peaches_Old)
                return "ico_GearItem__PinnacleCanPeaches_Old";

            if (Settings.instance.Peaches && !Settings.instance.Peaches_Old)
                return "ico_GearItem__PinnacleCanPeaches";
        }
        if (gi.name == "GEAR_CoffeeTin")
        {
            if (!Settings.instance.CoffeeCup && !Settings.instance.CoffeeTin_Old)
                return string.Empty;

            if (Settings.instance.CoffeeCup && Settings.instance.CoffeeTin_Old)
                return string.Empty;

            if (!Settings.instance.CoffeeCup && Settings.instance.CoffeeTin_Old)
                return "ico_GearItem__CoffeeTin_Old";

            if (Settings.instance.CoffeeCup && !Settings.instance.CoffeeTin_Old)
                return "ico_GearItem__CoffeeTin";
        }
        if (gi.name == "GEAR_Crackers")
        {
            if (!Settings.instance.Crackers && !Settings.instance.Crackers_Old)
                return string.Empty;

            if (Settings.instance.Crackers && Settings.instance.Crackers_Old)
                return string.Empty;

            if (!Settings.instance.Crackers && Settings.instance.Crackers_Old)
                return "ico_GearItem__Crackers_Old";

            if (Settings.instance.Crackers && !Settings.instance.Crackers_Old)
                return "ico_GearItem__Crackers";
        }
        if (gi.name == "GEAR_MRE")
        {
            if (!Settings.instance.MRE && !Settings.instance.MRE_Old)
                return string.Empty;

            if (Settings.instance.MRE && Settings.instance.MRE_Old)
                return string.Empty;

            if (!Settings.instance.MRE && Settings.instance.MRE_Old)
                return "ico_GearItem__MRE_Old";

            if (Settings.instance.Crackers && !Settings.instance.MRE_Old)
                return "ico_GearItem__MRE";
        }
        if (gi.name == "GEAR_Soda")
        {
            if (!Settings.instance.Soda && !Settings.instance.Soda_Old)
                return string.Empty;

            if (Settings.instance.Soda && Settings.instance.Soda_Old)
                return string.Empty;

            if (!Settings.instance.Soda && Settings.instance.Soda_Old)
                return "ico_GearItem__Soda_Old";

            if (Settings.instance.Soda && !Settings.instance.Soda_Old)
                return "ico_GearItem__Soda";
        }
        if (gi.name == "GEAR_SodaOrange")
        {
            if (!Settings.instance.SodaOrange && !Settings.instance.SodaOrange_Old)
                return string.Empty;

            if (Settings.instance.SodaOrange && Settings.instance.SodaOrange_Old)
                return string.Empty;

            if (!Settings.instance.SodaOrange && Settings.instance.SodaOrange_Old)
                return "ico_GearItem__SodaOrange_Old";

            if (Settings.instance.SodaOrange && !Settings.instance.SodaOrange_Old)
                return "ico_GearItem__SodaOrange";
        }
        if (gi.name == "GEAR_SodaGrape")
        {
            if (!Settings.instance.GrapeSoda && !Settings.instance.SodaGrape_Old)
                return string.Empty;

            if (Settings.instance.GrapeSoda && Settings.instance.SodaGrape_Old)
                return string.Empty;

            if (!Settings.instance.GrapeSoda && Settings.instance.SodaGrape_Old)
                return "ico_GearItem__SodaGrape_Old";

            if (Settings.instance.GrapeSoda && !Settings.instance.SodaGrape_Old)
                return "ico_GearItem__SodaGrape";
        }
        if (textureMapping.TryGetValue(gi.name, out var textureName))
        {
            return textureName;
        }

        return string.Empty;
    }
}