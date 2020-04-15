using System;
using System.Reflection;
using Harmony;
using UnityEngine;

namespace NoCrashfish
{
    public class Mod
    {
        public static void Load()
        {
            try
            {
                HarmonyInstance.Create("subnautica.nocrashfish.mod").PatchAll(Assembly.GetExecutingAssembly());
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }
    }
}
