using HarmonyLib;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Siege;

namespace BreakAndEnter
{
    [HarmonyPatch(typeof(DefaultTroopSacrificeModel))]
    public static class Patches
    {
        [HarmonyPostfix]
        [HarmonyPatch("GetLostTroopCountForBreakingInBesiegedSettlement")]
        private static void GetLostTroopCountForBreakingInBesiegedSettlementPostfix(
            ref int __result,
            MobileParty party,
            SiegeEvent siegeEvent)
        {
            __result = 0;
        }

        [HarmonyPostfix]
        [HarmonyPatch("GetLostTroopCountForBreakingOutOfBesiegedSettlement")]
        private static void GetLostTroopCountForBreakingOutOfBesiegedSettlementPostfix(
            ref int __result,
            MobileParty party,
            SiegeEvent siegeEvent)
        {
            __result = 0;
        }
    }
}