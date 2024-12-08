using HarmonyLib;
using RimWorld;
using Verse;

namespace Progenitor;

[HarmonyPatch(typeof(Bill), nameof(Bill.PawnAllowedToStartAnew))]
public static class Bill_PawnAllowedToStartAnew
{
    public static void Prefix()
    {
        Log.Message("Prefix Bill_PawnAllowedToStartAnew");
    }

    public static void Postfix(Bill __instance, ref Pawn p, ref bool __result)
    {
        Log.Message("Postfix Bill_PawnAllowedToStartAnew");
        if (p.kindDef == Progenitor_DefOf.MP_Mech_Progenitor_Kind && __instance is not Bill_Mech)
        {
            __result = false;
        }
    }
}