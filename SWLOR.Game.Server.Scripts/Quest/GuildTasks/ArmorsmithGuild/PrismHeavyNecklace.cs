using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.ArmorsmithGuild
{
    public class PrismHeavyNecklace: AbstractQuest
    {
        public PrismHeavyNecklace()
        {
            CreateQuest(214, "Armorsmith Guild Task: 1x Prism Heavy Necklace", "arm_tsk_214")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "prism_neck_h", 1, true)

                .AddRewardGold(395)
                .AddRewardGuildPoints(GuildType.ArmorsmithGuild, 82);
        }
    }
}
