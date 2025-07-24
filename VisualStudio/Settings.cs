using ModSettings;

namespace RetroTexturesMod
{
    internal class Settings : JsonModSettings
    {
        internal static Settings instance = new Settings();

        [Section("Fire Starting Category")]

        [Name("Enable")]
        [Description("Enables Retexture for Fire Starting Category Items. Scene Reload Required for texture change. Game Restart required to remove the texture.")]
        public bool FireStartingCategory = false;

        [Name("Accelerant")]
        [Description("Changes the Accelerant Texture and Inventory Icon to the old one.")]
        public bool Accelerant = false;

        [Name("Books")]
        [Description("Changes the Book Texture and Inventory Icon to the old one.")]
        public bool Book = false;

        [Name("CardBoard Matches")]
        [Description("Changes the CardBoard Matches Texture and Inventory Icon to the old one.")]
        public bool CardBoardMatches = false;

        [Name("Cattail Heads ")]
        [Description("Changes the Cattail Head Texture and Inventory Icon to the old one.")]
        public bool CatTailTinder = false;

        [Name("Wood Matches")]
        [Description("Changes the Wood Matches Texture and Inventory Icon to the old one.")]
        public bool WoodMatches = false;

        [Section("First Aid Category")]

        [Name("Enable")]
        [Description("Enables Retexture for First Aid Category Items. Scene Reload Required for texture change. Game Restart required to remove the texture.")]
        public bool FirstAidCategory = false;

        [Name("Hydrogen Peroxide")]
        [Description("Changes the Hydrogen Peroxide Texture and Inventory Icon to the old one.")]
        public bool HydrogenPeroxide = false;

        [Name("Painkillers")]
        [Description("Changes the Painkiller Texture and Inventory Icon to the old one.")]
        public bool PainKillers = false;

        [Name("Reishi Tea")]
        [Description("Changes the Reishi Tea Texture and Inventory Icon to the old one.")]
        public bool ReishiTea = false;

        [Name("Rosehip Tea")]
        [Description("Changes the Rosehip Tea Texture and Inventory Icon to the old one.")]
        public bool RosehipTea = false;

        [Name("Water Purification Tablets")]
        [Description("Changes the Water Purification Tablets Texture and Inventory Icon to the old one.")]
        public bool WaterTablets = false;

        [Section("Food & Drinks")]

        [Name("Enable")]
        [Description("Enables Retexture for Food And Drinks Category Items. Scene Reload Required for texture change. Game Restart required to remove the texture.")]
        public bool FoodCategory = false;

        [Section("Processed Food")]

        [Name("Beef jerky")]
        [Description("Changes the Beef Jerky Texture and Inventory Icon to the old one.")]
        public bool BeefJerky = false;

        [Name("Candy Bar")]
        [Description("Changes the Candy Bar Texture and Inventory Icon to the old one.")]
        public bool CandyBar = false;

        [Name("Energy Bar")]
        [Description("Changes the Energy Bar Texture and Inventory Icon to the old one.")]
        public bool EnergyBar = false;

        [Name("Granola Bar")]
        [Description("Changes the Granola Bar Texture and Inventory Icon to the old one.")]
        public bool GranolaBar = false;

        [Name("MRE")]
        [Description("Changes the MRE Texture and Inventory Icon to the old one.")]
        public bool MRE = false;

        [Name("Peanut Butter")]
        [Description("Changes the Peanut Butter Texture and Inventory Icon to the old one.")]
        public bool PeanutButter = false;

        [Name("Salty Crackers")]
        [Description("Changes the Salty Crackers Texture and Inventory Icon to the old one.")]
        public bool Crackers = false;

        [Section("Canned Food")]

        [Name("Canned Peaches")]
        [Description("Changes the Canned Peaches Texture and Inventory Icon to the old one.")]
        public bool Peaches = false;

        [Name("Canned Pork and Beans")]
        [Description("Changes the Canned Pork and Beans Texture and Inventory Icon to the old one.")]
        public bool Beans = false;

        [Name("Condensed Milk")]
        [Description("Changes the Condensed Milk Texture and Inventory Icon to the old one.")]
        public bool Milk = false;

        [Name("Dog Food")]
        [Description("Changes the Dog Food Texture and Inventory Icon to the old one.")]
        public bool DogFood = false;

        [Name("Tin of Sardines")]
        [Description("Changes the Sardines Texture and Inventory Icon to the old one.")]
        public bool Sardines = false;

        [Name("Tomato Soup")]
        [Description("Changes the Tomato Soup Texture and Inventory Icon to the old one.")]
        public bool TomatoSoup = false;

        [Section("Plant Based Food")]

        [Name("Cattail Stalk")]
        [Description("Changes the Cattail Stalk Texture and Inventory Icon to the old one.")]
        public bool CattailStalk = false;

        [Section("Drinks")]

        [Name("Coffee")]
        [Description("Changes the Coffee Texture and Inventory Icon to the old one.")]
        public bool CoffeeCup = false;

        [Name("Herbal Tea")]
        [Description("Changes the Herbal Tea Texture and Inventory Icon to the old one.")]
        public bool GreenTeaCup = false;

        [Name("Orange Soda")]
        [Description("Changes the Orange Soda Texture and Inventory Icon to the old one.")]
        public bool SodaOrange = false;

        [Name("Stacy's Grape Soda")]
        [Description("Changes the Stacy's Grape Soda Texture and Inventory Icon to the old one.")]
        public bool GrapeSoda = false;

        [Name("Summit Soda")]
        [Description("Changes the Summit Soda Texture and Inventory Icon to the old one.")]
        public bool Soda = false;

        [Name("Water")]
        [Description("Changes the Water Texture and Inventory Icon to the old one.")]
        public bool Water = false;

        [Section("Tools Category ")]

        [Name("Enable")]
        [Description("Enables Retexture for Tools Category Items. Scene Reload Required for texture change. Game Restart required to remove the texture.")]
        public bool ToolCategory = false;

        [Name("Bedroll")]
        [Description("Changes the Bedroll Texture and Inventory Icon to the old one.")]
        public bool Bedroll = false;

        [Name("Bear Skin Bedroll")]
        [Description("Changes the Bear Skin Bedroll Texture and Inventory Icon to the old one.")]
        public bool BearSkinBedroll = false;

        [Name("Can opener")]
        [Description("Changes the Can opener Texture and Inventory Icon to the old one.")]
        public bool CanOpener = false;

        [Name("Hatchet")]
        [Description("Changes the Hacksaw Texture and Inventory Icon to the old one.")]
        public bool Hatchet = false;

        [Name("Lamp Fuel")]
        [Description("Changes the Lamp Fuel Texture and Inventory Icon to the old one.")]
        public bool LampFuel = false;

        [Name("Jerry Can")]
        [Description("Changes the Jerry Can Texture and Inventory Icon to the old one.")]
        public bool JerryCan = false;

        [Name("Prybar")]
        [Description("Changes the Prybar Texture and Inventory Icon to the old one.")]
        public bool Prybar = false;

        [Name("Sewing Kit")]
        [Description("Changes the Sewing Kit Texture and Inventory Icon to the old one.")]
        public bool SewingKit = false;

        [Name("Simple Tools")]
        [Description("Changes the Simple Tools Texture and Inventory Icon to the old one.")]
        public bool Tools = false;

        [Section("Materials Category ")]

        [Name("Enable")]
        [Description("Enables Retexture for Materials Category Items. Scene Reload Required for texture change. Game Restart required to remove the texture.")]
        public bool MaterialCategory = false;

        [Name("Cloth")]
        [Description("Changes the Line Texture and Inventory Icon to the old one.")]
        public bool Cloth = false;

        [Name("Reishi Mushroom")]
        [Description("Changes the Reishi Mushroom Texture and Inventory Icon to the old one.")]
        public bool Reishi = false;

        [Name("Rosehip")]
        [Description("Changes the Rosehip Texture and Inventory Icon to the old one.")]
        public bool Rosehip = false;

        [Section("Research Books Category")]

        [Name("Enable")]
        [Description("Enables Retexture with Discontinued Assets. Scene Reload Required for texture change. Game Restart required to remove the texture.")]
        public bool ResearchBooks = false;

        [Name("Advanced Guns Guns Guns Book")]
        [Description("Changes the Advanced Guns Guns Guns Book Texture and Inventory Icon to the old one.")]
        public bool GunsAdvanced = false;

        [Name("Field Dressing Book")]
        [Description("Changes the Field Dressing Book's Texture and Inventory Icon to the old one.")]
        public bool HarvestBook = false;

        [Name("Frontier Shooting Guide")]
        [Description("Changes the Frontier Shooting Guide book Texture and Inventory Icon to the old one.")]
        public bool GunBook = false;

        [Name("Frozen Angler")]
        [Description("Changes the Frozen Angler book Texture and Inventory Icon to the old one.")]
        public bool IceFishing = false;

        [Name("Survive The Outdoors Book")]
        [Description("Changes the Survive The Outdoors Book Texture and Inventory Icon to the old one.")]
        public bool FireBook = false;

        [Name("Wildreness Kitchen Book")]
        [Description("Changes the Wildreness Kitchen Book Texture and Inventory Icon to the old one.")]
        public bool CookingBook = false;

        [Section("Discontinued Assets Category")]

        [Name("Enable")]
        [Description("Enables Retexture with Discontinued Assets. Scene Reload Required for texture change. Game Restart required to remove the texture.")]
        public bool Discontinued = false;

        [Name("Canned Pinnacle Peaches")]
        [Description("Replaces the Canned Pinnacle Peaches Texture and Inventory Icon. Disable respective item in Food Category before applying! (Game Restart Required)")]
        public bool Peaches_Old = false;

        [Name("Canned Pork and Beans")]
        [Description("Replaces the Canned Pork and Beans Texture and Inventory Icon. Disable respective item in Food Category before applying! (Game Restart Required)")]
        public bool Beans_Old = false;

        [Name("MRE")]
        [Description("Replaces the MRE Texture and Inventory Icon. Disable respective item in Food Category before applying! (Game Restart Required)")]
        public bool MRE_Old = false;

        [Name("Orange Soda")]
        [Description("Replaces the Orange Soda Texture and Inventory Icon. Disable respective item in Food Category before applying! (Game Restart Required)")]
        public bool SodaOrange_Old = false;

        [Name("Salty Crackers")]
        [Description("Replaces the Salty Crackers Texture and Inventory Icon. Disable respective item in Food Category before applying! (Game Restart Required)")]
        public bool Crackers_Old = false;

        [Name("Stacy's Grape Soda")]
        [Description("Replaces the Stacy's Grape Soda Texture and Inventory Icon. Disable respective item in Food Category before applying! (Game Restart Required)")]
        public bool SodaGrape_Old = false;

        [Name("Summit Soda")]
        [Description("Replaces the Summit Soda Texture and Inventory Icon. Disable respective item in Food Category before applying! (Game Restart Required)")]
        public bool Soda_Old = false;

        [Name("Tin of Coffee")]
        [Description("Replaces the Tin of Coffee Texture and Inventory Icon. Disable respective item in Food Category before applying! (Game Restart Required)")]
        public bool CoffeeTin_Old = false;


        [Section("Reset Settings")]
        [Name("Reset To Default")]
        [Description("Resets all settings to Default. (Game Restart Required to take effect.)")]
        public bool ResetSettings = false;

        protected override void OnChange(FieldInfo field, object? oldValue, object? newValue) => RefreshFields();

        protected override void OnConfirm()
        {
            ApplyReset();
            base.OnConfirm();
            instance.ResetSettings = false;
            RefreshGUI();
        }
        public static void ApplyReset()
        {
            if (instance.ResetSettings == true)
            {
                // Fire Starting Category
                instance.Accelerant = false;
                instance.WoodMatches = false;
                instance.CatTailTinder = false;
                instance.Book = false;
                instance.CardBoardMatches = false;
                // First Aid Category
                instance.HydrogenPeroxide = false;
                instance.PainKillers = false;
                instance.ReishiTea = false;
                instance.RosehipTea = false;
                instance.WaterTablets = false;

                // Food Category
                instance.BeefJerky = false;
                instance.CandyBar = false;
                instance.CattailStalk = false;
                instance.Milk = false;
                instance.CoffeeCup = false;
                instance.GreenTeaCup = false;
                instance.DogFood = false;
                instance.EnergyBar = false;
                instance.GranolaBar = false;
                instance.MRE = false;
                instance.SodaOrange = false;
                instance.PeanutButter = false;
                instance.Peaches = false;
                instance.Beans = false;
                instance.Crackers = false;
                instance.GrapeSoda = false;
                instance.Soda = false;
                instance.Sardines = false;
                instance.TomatoSoup = false;
                instance.Water = false;

                // Tool Category
                instance.BearSkinBedroll = false;
                instance.Bedroll = false;
                instance.CanOpener = false;
                instance.JerryCan = false;
                instance.LampFuel = false;
                instance.Hatchet = false;
                instance.SewingKit = false;

                // Material Category
                instance.Cloth = false;
                instance.Reishi = false;
                instance.Rosehip = false;

                // Cut Textures Category
                instance.Soda_Old = false;
                instance.SodaGrape_Old = false;
                instance.SodaOrange_Old = false;
                instance.Crackers_Old = false;
                instance.MRE_Old = false;
                instance.CoffeeTin_Old = false;
                instance.Peaches_Old = false;
                instance.Beans_Old = false;

                // Skill Books Category
                instance.HarvestBook = false;
                instance.GunBook = false;
                instance.CookingBook = false;
                instance.IceFishing = false;
                instance.FireBook = false;
                instance.GunsAdvanced = false;
            }
        }
        internal static void OnLoad()
        {
            instance.RefreshFields();
        }
        internal void RefreshFields()
        {
            if (instance.FireStartingCategory == true)  // Fire Starting Category
            {
                SetFieldVisible(nameof(instance.Accelerant), true);
                SetFieldVisible(nameof(instance.WoodMatches), true);
                SetFieldVisible(nameof(instance.CatTailTinder), true);
                SetFieldVisible(nameof(instance.Book), true);
                SetFieldVisible(nameof(instance.CardBoardMatches), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.Accelerant), false);
                SetFieldVisible(nameof(instance.WoodMatches), false);
                SetFieldVisible(nameof(instance.CatTailTinder), false);
                SetFieldVisible(nameof(instance.Book), false);
                SetFieldVisible(nameof(instance.CardBoardMatches), false);
            }
            if (instance.FirstAidCategory == true)      // First Aid Category
            {
                SetFieldVisible(nameof(instance.HydrogenPeroxide), true);
                SetFieldVisible(nameof(instance.PainKillers), true);
                SetFieldVisible(nameof(instance.ReishiTea), true);
                SetFieldVisible(nameof(instance.RosehipTea), true);
                SetFieldVisible(nameof(instance.WaterTablets), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.HydrogenPeroxide), false);
                SetFieldVisible(nameof(instance.PainKillers), false);
                SetFieldVisible(nameof(instance.ReishiTea), false);
                SetFieldVisible(nameof(instance.RosehipTea), false);
                SetFieldVisible(nameof(instance.WaterTablets), false);
            }
            if (instance.FoodCategory == true) //Food Category
            {
                SetFieldVisible(nameof(instance.BeefJerky), true);
                SetFieldVisible(nameof(instance.CandyBar), true);
                SetFieldVisible(nameof(instance.CattailStalk), true);
                SetFieldVisible(nameof(instance.Milk), true);
                SetFieldVisible(nameof(instance.CoffeeCup), true);
                SetFieldVisible(nameof(instance.GreenTeaCup), true);
                SetFieldVisible(nameof(instance.DogFood), true);
                SetFieldVisible(nameof(instance.EnergyBar), true);
                SetFieldVisible(nameof(instance.GranolaBar), true);
                SetFieldVisible(nameof(instance.MRE), true);
                SetFieldVisible(nameof(instance.SodaOrange), true);
                SetFieldVisible(nameof(instance.PeanutButter), true);
                SetFieldVisible(nameof(instance.Peaches), true);
                SetFieldVisible(nameof(instance.Beans), true);
                SetFieldVisible(nameof(instance.Crackers), true);
                SetFieldVisible(nameof(instance.GrapeSoda), true);
                SetFieldVisible(nameof(instance.Soda), true);
                SetFieldVisible(nameof(instance.Sardines), true);
                SetFieldVisible(nameof(instance.TomatoSoup), true);
                SetFieldVisible(nameof(instance.Water), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.BeefJerky), false);
                SetFieldVisible(nameof(instance.CandyBar), false);
                SetFieldVisible(nameof(instance.CattailStalk), false);
                SetFieldVisible(nameof(instance.Milk), false);
                SetFieldVisible(nameof(instance.CoffeeCup), false);
                SetFieldVisible(nameof(instance.DogFood), false);
                SetFieldVisible(nameof(instance.EnergyBar), false);
                SetFieldVisible(nameof(instance.GranolaBar), false);
                SetFieldVisible(nameof(instance.MRE), false);
                SetFieldVisible(nameof(instance.SodaOrange), false);
                SetFieldVisible(nameof(instance.Peaches), false);
                SetFieldVisible(nameof(instance.Beans), false);
                SetFieldVisible(nameof(instance.Crackers), false);
                SetFieldVisible(nameof(instance.GrapeSoda), false);
                SetFieldVisible(nameof(instance.Soda), false);
                SetFieldVisible(nameof(instance.Sardines), false);
                SetFieldVisible(nameof(instance.TomatoSoup), false);
                SetFieldVisible(nameof(instance.Water), false);
                SetFieldVisible(nameof(instance.GreenTeaCup), false);
                SetFieldVisible(nameof(instance.PeanutButter), false);


            }
            if (instance.ToolCategory == true) // Tool Category
            {
                SetFieldVisible(nameof(instance.BearSkinBedroll), true);
                SetFieldVisible(nameof(instance.Bedroll), true);
                SetFieldVisible(nameof(instance.CanOpener), true);
                SetFieldVisible(nameof(instance.Hatchet), true);
                SetFieldVisible(nameof(instance.JerryCan), true);
                SetFieldVisible(nameof(instance.LampFuel), true);
                SetFieldVisible(nameof(instance.Tools), true);
                SetFieldVisible(nameof(instance.Prybar), true);
                SetFieldVisible(nameof(instance.SewingKit), true);

            }
            else
            {
                SetFieldVisible(nameof(instance.BearSkinBedroll), false);
                SetFieldVisible(nameof(instance.Bedroll), false);
                SetFieldVisible(nameof(instance.CanOpener), false);
                SetFieldVisible(nameof(instance.Hatchet), false);
                SetFieldVisible(nameof(instance.JerryCan), false);
                SetFieldVisible(nameof(instance.LampFuel), false);
                SetFieldVisible(nameof(instance.Tools), false);
                SetFieldVisible(nameof(instance.Prybar), false);
                SetFieldVisible(nameof(instance.SewingKit), false);

            }
            if (instance.MaterialCategory == true) //Material Category
            {
                SetFieldVisible(nameof(instance.Cloth), true);
                SetFieldVisible(nameof(instance.Reishi), true);
                SetFieldVisible(nameof(instance.Rosehip), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.Cloth), false);
                SetFieldVisible(nameof(instance.Reishi), false);
                SetFieldVisible(nameof(instance.Rosehip), false);

            }
            if (instance.Discontinued == true) //Cut Textures Category
            {
                SetFieldVisible(nameof(instance.Soda_Old), true);
                SetFieldVisible(nameof(instance.SodaGrape_Old), true);
                SetFieldVisible(nameof(instance.SodaOrange_Old), true);
                SetFieldVisible(nameof(instance.Crackers_Old), true);
                SetFieldVisible(nameof(instance.MRE_Old), true);
                SetFieldVisible(nameof(instance.CoffeeTin_Old), true);
                SetFieldVisible(nameof(instance.Peaches_Old), true);
                SetFieldVisible(nameof(instance.Beans_Old), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.Soda_Old), false);
                SetFieldVisible(nameof(instance.SodaGrape_Old), false);
                SetFieldVisible(nameof(instance.SodaOrange_Old), false);
                SetFieldVisible(nameof(instance.Crackers_Old), false);
                SetFieldVisible(nameof(instance.MRE_Old), false);
                SetFieldVisible(nameof(instance.CoffeeTin_Old), false);
                SetFieldVisible(nameof(instance.Peaches_Old), false);
                SetFieldVisible(nameof(instance.Beans_Old), false);
            }
            if (instance.ResearchBooks == true) //Skill Books
            {
                SetFieldVisible(nameof(instance.HarvestBook), true);
                SetFieldVisible(nameof(instance.GunBook), true);
                SetFieldVisible(nameof(instance.CookingBook), true);
                SetFieldVisible(nameof(instance.IceFishing), true);
                SetFieldVisible(nameof(instance.FireBook), true);
                SetFieldVisible(nameof(instance.GunsAdvanced), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.HarvestBook), false);
                SetFieldVisible(nameof(instance.GunBook), false);
                SetFieldVisible(nameof(instance.CookingBook), false);
                SetFieldVisible(nameof(instance.IceFishing), false);
                SetFieldVisible(nameof(instance.FireBook), false);
                SetFieldVisible(nameof(instance.GunsAdvanced), false);

            }
        }
    }
}