using System.Reflection;
using HarmonyLib;
using Verse;

namespace NoMoreAutoroof
{
    // Token: 0x02000002 RID: 2
    [StaticConstructorOnStartup]
    internal class NoMoreAutoroof : Mod
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public NoMoreAutoroof(ModContentPack content) : base(content)
        {
            var harmonyInstance = new Harmony("fed1s.rimworld.NoMoreAutoroof");
            harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}