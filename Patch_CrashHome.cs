using Harmony;
using UnityEngine;

namespace NoCrashfish
{
    [HarmonyPatch(typeof(CrashHome))]
    [HarmonyPatch("Start")]
    public class Patch_CrashHome
    {
        static bool Prefix(CrashHome __instance)
        {
            __instance.crashPrefab = null;

            __instance.spawnTime = 1f;
            return true;
        }

        static void Postfix(CrashHome __instance)
        {
            SafeAnimator.SetBool(__instance.animator, "attacking", true);

            __instance.spawnTime = -1f;

            __instance.gameObject.AddComponent<Destructor>();
        }
    }
}
