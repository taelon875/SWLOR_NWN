using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.ArmorsmithGuild
{
    public class ForceHelmetIII: AbstractQuest
    {
        public ForceHelmetIII()
        {
            CreateQuest(175, "Armorsmith Guild Task: 1x Force Helmet III", "arm_tsk_175")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "helmet_f3", 1, true)

                .AddRewardGold(285)
                .AddRewardGuildPoints(GuildType.ArmorsmithGuild, 59);
        }
    }
}
