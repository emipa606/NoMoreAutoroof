using Verse;

namespace NoMoreAutoroof;

/// <summary>
///     Definition of the settings for the mod
/// </summary>
internal class NoMoreAutoroofSettings : ModSettings
{
    public bool BuildRoof;

    /// <summary>
    ///     Saving and loading the values
    /// </summary>
    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref BuildRoof, "BuildRoof");
    }
}