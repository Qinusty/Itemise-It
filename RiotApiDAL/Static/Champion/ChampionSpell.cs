using System.ComponentModel.DataAnnotations.Schema;
using RiotApi.Net.RestClient.Dto.LolStaticData.Champion;
using System.ComponentModel.DataAnnotations;
using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;
using System.Collections.Generic;

namespace RiotApiDAL.Static.Champion
{
    
    public class ChampionSpell
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string name { get; set; }
        
        public string key { get; set; }

        public virtual Image image { get; set; }

        public string description { get; set; }

        public string sanitizedDescription { get; set; }

        public string cooldownBurn { get; set; }

        public string costBurn { get; set; }

        public int maxRank { get; set; }

        public string resource { get; set; }

        public virtual ICollection<SpellVars> vars { get; set; }

        public virtual ICollection<string> effectBurn { get; set; }
        
        public string rangeBurn { get; set; }

        public string costType { get; set; }

        public ChampionSpell(ChampionSpellDto champSpell)
        {
            name = champSpell.Name;
            key = champSpell.Name;
            description = champSpell.Description;
            sanitizedDescription = champSpell.SanitizedDescription;
            cooldownBurn = champSpell.CooldownBurn;
            image = AutoMapper.Mapper.Map<Image>(champSpell.Image);
            vars = new List<SpellVars>();
            if (champSpell.Vars != null)
            {
                foreach (var variable in champSpell.Vars)
                {
                    vars.Add(new SpellVars(variable));
                }
            }
            effectBurn = champSpell.EffectBurn;
            rangeBurn = champSpell.RangeBurn;
            costBurn = champSpell.CostBurn;
            costType = champSpell.CostType;
            this.resource = champSpell.Resource;
        }
        public ChampionSpell() { }
    }
    public class SpellVars
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public virtual ICollection<double> coefficients { get; set; }

        public string dynamics { get; set; }

        public string key { get; set; }
        
        public string ranksWith { get; set; }
        
        public string link { get; set; }

        public SpellVars(SpellVarsDto vars)
        {
            this.coefficients = new List<double>();
            foreach (var tempVar in vars.Coeff)
            {
                coefficients.Add(tempVar);
            }
            this.dynamics = vars.Dyn;
            this.key = vars.Key;
            this.ranksWith = vars.RanksWith;
            this.link = vars.Link;
        }
        public SpellVars() { }
    }

}
