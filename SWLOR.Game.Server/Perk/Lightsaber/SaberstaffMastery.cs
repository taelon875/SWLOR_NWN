﻿using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.GameObject;
using SWLOR.Game.Server.NWNX;
using SWLOR.Game.Server.Service;

using static NWN._;

namespace SWLOR.Game.Server.Perk.Lightsaber
{
    public class SaberstaffMastery : IPerkHandler
    {
        public PerkType PerkType => PerkType.SaberstaffMastery;

        public string CanCastSpell(NWCreature oPC, NWObject oTarget, int spellTier)
        {
            return string.Empty;
        }
        
        public int FPCost(NWCreature oPC, int baseFPCost, int spellTier)
        {
            return baseFPCost;
        }

        public float CastingTime(NWCreature oPC, float baseCastingTime, int spellTier)
        {
            return baseCastingTime;
        }

        public float CooldownTime(NWCreature oPC, float baseCooldownTime, int spellTier)
        {
            return baseCooldownTime;
        }

        public int? CooldownCategoryID(NWCreature creature, int? baseCooldownCategoryID, int spellTier)
        {
            return baseCooldownCategoryID;
        }

        public void OnImpact(NWCreature creature, NWObject target, int perkLevel, int spellTier)
        {
        }

        public void OnPurchased(NWCreature creature, int newLevel)
        {
            ApplyFeatChanges(creature, null);
        }

        public void OnRemoved(NWCreature creature)
        {
            RemoveFeats(creature);
        }

        public void OnItemEquipped(NWCreature creature, NWItem oItem)
        {
            if (oItem.CustomItemType != CustomItemType.Saberstaff) return;
            ApplyFeatChanges(creature, null);
        }

        public void OnItemUnequipped(NWCreature creature, NWItem oItem)
        {
            if (oItem.CustomItemType != CustomItemType.Saberstaff) return;
            ApplyFeatChanges(creature, oItem);
        }

        public void OnCustomEnmityRule(NWCreature creature, int amount)
        {
        }

        private void RemoveFeats(NWCreature creature)
        {
            NWNXCreature.RemoveFeat(creature, FEAT_TWO_WEAPON_FIGHTING);
            NWNXCreature.RemoveFeat(creature, FEAT_AMBIDEXTERITY);
            NWNXCreature.RemoveFeat(creature, FEAT_IMPROVED_TWO_WEAPON_FIGHTING);
        }

        private void ApplyFeatChanges(NWCreature creature, NWItem unequippedItem)
        {
            NWItem equipped = unequippedItem ?? creature.RightHand;

            if (Equals(equipped, unequippedItem) || equipped.CustomItemType != CustomItemType.Saberstaff)
            {
                RemoveFeats(creature);
                return;
            }

            int perkLevel = PerkService.GetCreaturePerkLevel(creature, PerkType.SaberstaffMastery);
            NWNXCreature.AddFeat(creature, FEAT_TWO_WEAPON_FIGHTING);

            if (perkLevel >= 2)
            {
                NWNXCreature.AddFeat(creature, FEAT_AMBIDEXTERITY);
            }
            if (perkLevel >= 3)
            {
                NWNXCreature.AddFeat(creature, FEAT_IMPROVED_TWO_WEAPON_FIGHTING);
            }
        }

        public bool IsHostile()
        {
            return false;
        }

        public void OnConcentrationTick(NWCreature creature, NWObject target, int perkLevel, int tick)
        {
            
        }
    }
}
