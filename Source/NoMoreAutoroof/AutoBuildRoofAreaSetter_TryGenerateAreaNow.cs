using HarmonyLib;
using Verse;

namespace NoMoreAutoroof;

[HarmonyPatch(typeof(AutoBuildRoofAreaSetter), "TryGenerateAreaNow", typeof(Room))]
internal static class AutoBuildRoofAreaSetter_TryGenerateAreaNow
{
    public static bool Prefix()
    {
        return NoMoreAutoroofMod.Instance.Settings.BuildRoof;
    }
}