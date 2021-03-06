using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.EngineeringGuild
{
    public class HitPointsI: AbstractQuest
    {
        public HitPointsI()
        {
            CreateQuest(395, "Engineering Guild Task: 1x Hit Points I", "eng_tsk_395")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "rune_hp1", 1, true)

                .AddRewardGold(70)
                .AddRewardGuildPoints(GuildType.EngineeringGuild, 15);
        }
    }
}
