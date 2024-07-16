using HarmonyLib;
using Verse;

namespace NoMoreAutoroof;

[HarmonyPatch(typeof(AutoBuildRoofAreaSetter), "TryGenerateAreaNow", typeof(Room))]
internal class AutoBuildRoofAreaSetter_AutoBuildRoofAreaSetterTick_First
{
    [HarmonyPrefix]
    private static bool TryGenerateAreaNow_Fix()
    {
        return NoMoreAutoroofMod.instance.Settings.BuildRoof;
    }
}