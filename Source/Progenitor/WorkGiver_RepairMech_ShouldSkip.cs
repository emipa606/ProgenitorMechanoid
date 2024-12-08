using HarmonyLib;
using RimWorld;
using Verse;

namespace Progenitor;

[HarmonyPatch(typeof(WorkGiver_RepairMech), nameof(WorkGiver_RepairMech.ShouldSkip))]
public static class WorkGiver_RepairMech_ShouldSkip
{
    public static bool Prefix(Pawn pawn, ref bool __result)
    {
        if (!pawn.RaceProps.IsMechanoid || MechRepairUtility.CanRepair(pawn))
        {
            return true;
        }

        __result = false;
        return false;
    }
}