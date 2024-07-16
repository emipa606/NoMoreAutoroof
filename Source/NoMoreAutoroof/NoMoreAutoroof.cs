using System.Reflection;
using HarmonyLib;
using UnityEngine;
using Verse;

namespace NoMoreAutoroof;

[StaticConstructorOnStartup]
public static class NoMoreAutoroof
{
    public static readonly Texture2D ButtonNoAutoRoof = ContentFinder<Texture2D>.Get("UI/Buttons/NoAutoRoof");

    static NoMoreAutoroof()
    {
        new Harmony("fed1s.rimworld.NoMoreAutoroof").PatchAll(Assembly.GetExecutingAssembly());
    }
}