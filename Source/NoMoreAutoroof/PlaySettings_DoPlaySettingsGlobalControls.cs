using HarmonyLib;
using RimWorld;
using Verse;

namespace NoMoreAutoroof;

[HarmonyPatch(typeof(PlaySettings), nameof(PlaySettings.DoPlaySettingsGlobalControls))]
internal class PlaySettings_DoPlaySettingsGlobalControls
{
    private static void Prefix(WidgetRow row, bool worldView)
    {
        if (worldView)
        {
            return;
        }

        var toggleable = NoMoreAutoroofMod.Instance.Settings.BuildRoof;
        var buttonAutoDesignatePlantsCutMode = NoMoreAutoroof.ButtonNoAutoRoof;
        string text = toggleable
            ? "NoMoreAutoroof.ModeON".Translate()
            : "NoMoreAutoroof.ModeOFF".Translate();
        string tooltip = "NoMoreAutoroof.NoMoreAutoroof".Translate(text);
        row.ToggleableIcon(ref toggleable, buttonAutoDesignatePlantsCutMode, tooltip,
            SoundDefOf.Mouseover_ButtonToggle);
        NoMoreAutoroofMod.Instance.Settings.BuildRoof = toggleable;
    }
}