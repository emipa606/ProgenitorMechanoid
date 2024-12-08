using HarmonyLib;
using Verse;

namespace Progenitor;

[StaticConstructorOnStartup]
public static class HarmonyPatches
{
    static HarmonyPatches()
    {
        new Harmony("rimworld.smartkar.progenitor.main").PatchAll();
    }
}