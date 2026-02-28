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
    }
}

