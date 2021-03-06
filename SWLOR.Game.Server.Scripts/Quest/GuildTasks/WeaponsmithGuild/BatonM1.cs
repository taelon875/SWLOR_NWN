using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.Quest;

namespace SWLOR.Game.Server.Scripts.Quest.GuildTasks.WeaponsmithGuild
{
    public class BatonM1: AbstractQuest
    {
        public BatonM1()
        {
            CreateQuest(250, "Weaponsmith Guild Task: 1x Baton M1", "wpn_tsk_250")
                .IsRepeatable()

                .AddObjectiveCollectItem(1, "mace_1", 1, true)

                .AddRewardGold(85)
                .AddRewardGuildPoints(GuildType.WeaponsmithGuild, 19);
        }
    }
}
