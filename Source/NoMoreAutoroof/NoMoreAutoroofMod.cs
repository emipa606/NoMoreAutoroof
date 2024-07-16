﻿using Verse;

namespace NoMoreAutoroof;

[StaticConstructorOnStartup]
internal class NoMoreAutoroofMod : Mod
{
    /// <summary>
    ///     The instance of the settings to be read by the mod
    /// </summary>
    public static NoMoreAutoroofMod instance;


    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="content"></param>
    public NoMoreAutoroofMod(ModContentPack content) : base(content)
    {
        instance = this;
        Settings = GetSettings<NoMoreAutoroofSettings>();
    }

    /// <summary>
    ///     The instance-settings for the mod
    /// </summary>
    internal NoMoreAutoroofSettings Settings { get; }
}