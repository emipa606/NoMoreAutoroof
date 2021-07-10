using HarmonyLib;
using Verse;

namespace NoMoreAutoroof
{
    // Token: 0x02000003 RID: 3
    [HarmonyPatch(typeof(AutoBuildRoofAreaSetter), "TryGenerateAreaNow", typeof(Room))]
    internal class AutoBuildRoofAreaSetter_AutoBuildRoofAreaSetterTick_First
    {
        // Token: 0x06000002 RID: 2 RVA: 0x00002080 File Offset: 0x00000280
        [HarmonyPrefix]
        private static bool TryGenerateAreaNow_Fix()
        {
            return false;
        }
    }
}