using System.Reflection;
using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace BreakAndEnter
{
    public class Main : MBSubModuleBase
    {
        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();
            var harmony = new Harmony("BreakAndEnter.harmony");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}