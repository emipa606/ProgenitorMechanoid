using RimWorld;
using Verse;

[DefOf]
public static class Progenitor_DefOf
{
    public static PawnKindDef MP_Mech_Progenitor_Kind;

    static Progenitor_DefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(Progenitor_DefOf));
    }
}