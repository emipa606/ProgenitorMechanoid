using HarmonyLib;
using RimWorld;
using Verse;

namespace Progenitor;

[HarmonyPatch(typeof(WorkGiver_RepairMech), nameof(WorkGiver_RepairMech.HasJobOnThing))]
public static class WorkGiver_RepairMech_HasJobOnThing
{
    public static bool Prefix(Pawn pawn, Thing t, ref bool __result)
    {
        if (pawn != t && (pawn.kindDef == Progenitor_DefOf.MP_Mech_Progenitor_Kind || !pawn.IsColonyMech))
        {
            return true;
        }

        __result = false;
        return false;
    }
}