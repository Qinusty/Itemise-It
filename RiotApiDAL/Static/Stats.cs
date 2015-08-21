using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;
using System.Reflection;

namespace RiotApiDAL.Static
{

    public class ChampStats : StatsDto
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public ChampStats() { }
        

    }
    public class ItemStats : BasicDataStatsDto
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public ItemStats() { }
        public static ItemStats operator +(ItemStats i1, ItemStats i2)
        {
            var retVal = new ItemStats();
            #region "+"
            retVal.FlatArmorMod = i1.FlatArmorMod + i2.FlatArmorMod;
            retVal.FlatAttackSpeedMod = i1.FlatAttackSpeedMod + i2.FlatAttackSpeedMod;
            retVal.FlatBlockMod = i1.FlatBlockMod + i2.FlatBlockMod;
            retVal.FlatCritChanceMod = i1.FlatCritChanceMod + i2.FlatCritChanceMod;
            retVal.FlatCritDamageMod = i1.FlatCritDamageMod + i2.FlatCritDamageMod;
            retVal.FlatEnergyPoolMod = i1.FlatEnergyPoolMod + i2.FlatEnergyPoolMod;
            retVal.FlatEnergyRegenMod = i1.FlatEnergyRegenMod + i2.FlatEnergyRegenMod;
            retVal.FlatEXPBonus = i1.FlatEXPBonus + i2.FlatEXPBonus;
            retVal.FlatHPPoolMod = i1.FlatHPPoolMod + i2.FlatHPPoolMod;
            retVal.FlatHPRegenMod = i1.FlatHPRegenMod + i2.FlatHPRegenMod;
            retVal.FlatMagicDamageMod = i1.FlatMagicDamageMod + i2.FlatMagicDamageMod;
            retVal.FlatMovementSpeedMod = i1.FlatMovementSpeedMod + i2.FlatMovementSpeedMod;
            retVal.FlatMPPoolMod = i1.FlatMPPoolMod + i2.FlatMPPoolMod;
            retVal.FlatMPRegenMod = i1.FlatMPRegenMod + i2.FlatMPRegenMod;
            retVal.FlatPhysicalDamageMod = i1.FlatPhysicalDamageMod + i2.FlatPhysicalDamageMod;
            retVal.FlatSpellBlockMod = i1.FlatSpellBlockMod + i2.FlatSpellBlockMod;
            retVal.PercentAttackSpeedMod = i1.PercentAttackSpeedMod + i2.PercentAttackSpeedMod;
            retVal.PercentBlockMod = i1.PercentBlockMod + i2.PercentBlockMod;
            retVal.PercentCritChanceMod = i1.PercentCritChanceMod + i2.PercentCritChanceMod;
            retVal.PercentCritDamageMod = i1.PercentCritDamageMod + i2.PercentCritDamageMod;
            retVal.PercentDodgeMod = i1.PercentDodgeMod + i2.PercentDodgeMod;
            retVal.PercentEXPBonus = i1.PercentEXPBonus + i2.PercentEXPBonus;
            retVal.PercentHPPoolMod = i1.PercentHPPoolMod + i2.PercentHPPoolMod;
            retVal.PercentHPRegenMod = i1.PercentHPRegenMod + i2.PercentHPRegenMod;
            retVal.PercentLifeStealMod = i1.PercentLifeStealMod + i2.PercentLifeStealMod;
            retVal.PercentMagicDamageMod = i1.PercentMagicDamageMod + i2.PercentMagicDamageMod;
            retVal.PercentMovementSpeedMod = i1.PercentMovementSpeedMod + i2.PercentMovementSpeedMod;
            retVal.PercentMPPoolMod = i1.PercentMPPoolMod + i2.PercentMPPoolMod;
            retVal.PercentMPRegenMod = i1.PercentMPRegenMod + i2.PercentMPRegenMod;
            retVal.PercentPhysicalDamageMod = i1.PercentPhysicalDamageMod + i2.PercentPhysicalDamageMod;
            retVal.PercentSpellBlockMod = i1.PercentSpellBlockMod + i2.PercentSpellBlockMod;
            retVal.PercentSpellVampMod = i1.PercentSpellVampMod + i2.PercentSpellVampMod;
            retVal.RFlatArmorModPerLevel = i1.RFlatArmorModPerLevel + i2.RFlatArmorModPerLevel;
            retVal.RFlatArmorPenetrationMod = i1.RFlatArmorPenetrationMod + i2.RFlatArmorPenetrationMod;
            retVal.RFlatArmorPenetrationModPerLevel = i1.RFlatArmorPenetrationModPerLevel + i2.RFlatArmorPenetrationModPerLevel;
            retVal.RFlatCritChanceModPerLevel = i1.RFlatCritChanceModPerLevel + i2.RFlatCritChanceModPerLevel;
            retVal.RFlatCritDamageModPerLevel = i1.RFlatCritDamageModPerLevel + i2.RFlatCritDamageModPerLevel;
            retVal.RFlatDodgeMod = i1.RFlatDodgeMod + i2.RFlatDodgeMod;
            retVal.RFlatDodgeModPerLevel = i1.RFlatDodgeModPerLevel + i2.RFlatDodgeModPerLevel;
            retVal.RFlatEnergyModPerLevel = i1.RFlatEnergyModPerLevel + i2.RFlatEnergyModPerLevel;
            retVal.RFlatEnergyRegenModPerLevel = i1.RFlatEnergyRegenModPerLevel + i2.RFlatEnergyRegenModPerLevel;
            retVal.RFlatGoldPer10Mod = i1.RFlatGoldPer10Mod + i2.RFlatGoldPer10Mod;
            retVal.RFlatHPModPerLevel = i1.RFlatHPModPerLevel + i2.RFlatHPModPerLevel;
            retVal.RFlatHPRegenModPerLevel = i1.RFlatHPRegenModPerLevel + i2.RFlatHPRegenModPerLevel;
            retVal.RFlatMagicDamageModPerLevel = i1.RFlatMagicDamageModPerLevel + i2.RFlatMagicDamageModPerLevel;
            retVal.RFlatMagicPenetrationMod = i1.RFlatMagicPenetrationMod + i2.RFlatMagicPenetrationMod;
            retVal.RFlatMagicPenetrationModPerLevel = i1.RFlatMagicPenetrationModPerLevel + i2.RFlatMagicPenetrationModPerLevel;
            retVal.RFlatMovementSpeedModPerLevel = i1.RFlatMovementSpeedModPerLevel + i2.RFlatMovementSpeedModPerLevel;
            retVal.RFlatMPModPerLevel = i1.RFlatMPModPerLevel + i2.RFlatMPModPerLevel;
            retVal.RFlatMPRegenModPerLevel = i1.RFlatMPRegenModPerLevel + i2.RFlatMPRegenModPerLevel;
            retVal.RFlatPhysicalDamageModPerLevel = i1.RFlatPhysicalDamageModPerLevel + i2.RFlatPhysicalDamageModPerLevel;
            retVal.RFlatSpellBlockModPerLevel = i1.RFlatSpellBlockModPerLevel + i2.RFlatSpellBlockModPerLevel;
            retVal.RFlatTimeDeadMod = i1.RFlatTimeDeadMod + i2.RFlatTimeDeadMod;
            retVal.RFlatTimeDeadModPerLevel = i1.RFlatTimeDeadModPerLevel + i2.RFlatTimeDeadModPerLevel;
            retVal.RPercentArmorPenetrationMod = i1.RPercentArmorPenetrationMod + i2.RPercentArmorPenetrationMod;
            retVal.RPercentArmorPenetrationModPerLevel = i1.RPercentArmorPenetrationModPerLevel + i2.RPercentArmorPenetrationModPerLevel;
            retVal.RPercentAttackSpeedModPerLevel = i1.RPercentAttackSpeedModPerLevel + i2.RPercentAttackSpeedModPerLevel;
            retVal.RPercentCooldownMod = i1.RPercentCooldownMod + i2.RPercentCooldownMod;
            retVal.RPercentCooldownModPerLevel = i1.RPercentCooldownModPerLevel + i2.RPercentCooldownModPerLevel;
            retVal.RPercentMagicPenetrationMod = i1.RPercentMagicPenetrationMod + i2.RPercentMagicPenetrationMod;
            retVal.RPercentMagicPenetrationModPerLevel = i1.RPercentMagicPenetrationModPerLevel + i2.RPercentMagicPenetrationModPerLevel;
            retVal.RPercentMovementSpeedModPerLevel = i1.RPercentMovementSpeedModPerLevel + i2.RPercentMovementSpeedModPerLevel;
            retVal.RPercentTimeDeadMod = i1.RPercentTimeDeadMod + i2.RPercentTimeDeadMod;
            retVal.RPercentTimeDeadModPerLevel = i1.RPercentTimeDeadModPerLevel + i2.RPercentTimeDeadModPerLevel;
            #endregion
            return retVal;
        }
    }
}