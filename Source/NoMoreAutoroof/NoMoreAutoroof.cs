using System.Reflection;
using HarmonyLib;
using Verse;

namespace NoMoreAutoroof;

[StaticConstructorOnStartup]
internal class NoMoreAutoroof : Mod
{
    public NoMoreAutoroof(ModContentPack content) : base(content)
    {
        new Harmony("fed1s.rimworld.NoMoreAutoroof").PatchAll(Assembly.GetExecutingAssembly());
    }
}