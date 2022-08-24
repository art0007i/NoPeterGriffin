using HarmonyLib;
using NeosModLoader;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Collections.Generic;
using FrooxEngine;
using CodeX;

namespace NoPeterGriffin
{
    public class NoPeterGriffin : NeosMod
    {
        public override string Name => "NoPeterGriffin";
        public override string Author => "art0007i";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/art0007i/NoPeterGriffin/";
        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("me.art0007i.NoPeterGriffin");
            harmony.PatchAll();

        }
        [HarmonyPatch(typeof(AudioClip), "get_Data")]
        class NoPeterGriffinPatch
        {
            public static bool Prefix(ref AudioX __result)
            {
                // trust me this code is truly magical
                // you will never hear peter griffin again
                __result = null;
                return false;
            }
        }
    }
}