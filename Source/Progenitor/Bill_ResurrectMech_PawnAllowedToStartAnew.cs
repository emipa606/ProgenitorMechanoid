using HarmonyLib;
using RimWorld;
using Verse;

namespace Progenitor;

[HarmonyPatch(typeof(Bill_ResurrectMech), nameof(Bill_ResurrectMech.PawnAllowedToStartAnew))]
public static class Bill_ResurrectMech_PawnAllowedToStartAnew
{
    public static void Prefix(ref Pawn p)
    {
        if (p != null && p.RaceProps.IsMechanoid && p.kindDef == Progenitor_DefOf.MP_Mech_Progenitor_Kind &&
            p.GetOverseer() != null)
        {
            p = p.GetOverseer();
        }
    }
}