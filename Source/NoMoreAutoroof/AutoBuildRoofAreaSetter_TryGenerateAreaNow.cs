using HarmonyLib;
using Verse;

namespace NoMoreAutoroof;

[HarmonyPatch(typeof(AutoBuildRoofAreaSetter), "TryGenerateAreaNow", typeof(Room))]
internal class AutoBuildRoofAreaSetter_TryGenerateAreaNow
{
    private static bool Prefix()
    {
        return NoMoreAutoroofMod.Instance.Settings.BuildRoof;
    }
}