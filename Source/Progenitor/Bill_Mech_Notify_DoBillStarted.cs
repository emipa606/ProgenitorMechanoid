using HarmonyLib;
using RimWorld;
using Verse;

namespace Progenitor;

[HarmonyPatch(typeof(Bill_Mech), nameof(Bill_Mech.Notify_DoBillStarted))]
public static class Bill_Mech_Notify_DoBillStarted
{
    public static void Postfix(Bill_Mech __instance, Pawn billDoer)
    {
        if (billDoer.RaceProps.IsMechanoid && billDoer.kindDef == Progenitor_DefOf.MP_Mech_Progenitor_Kind)
        {
            __instance.boundPawn = billDoer.GetOverseer();
        }
    }
}