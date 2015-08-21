using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;
using RiotApiDAL.Static.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RiotApiDAL.Static.Champion
{
    public enum ParType
    {
        None, Mana, Heat, Energy, Rage, Ferocity
    }
    public class Champion
    {
        [Key]
        [Required]
        public int id { get; set; }

        public string name { get; set; }

        public string key { get; set; }

        public virtual ChampStats stats { get; set; }

        public virtual ChampionPassive passive { get; set; }

        public virtual ICollection<ChampionSpell> championSpells { get; set; }

        public string title { get; set; }

        public virtual Image image { get; set; }

        public Champion(RiotApi.Net.RestClient.Dto.LolStaticData.Champion.ChampionDto champ)
        {
            AutoMapper.Mapper.CreateMap<StatsDto, ChampStats>();
            this.id = champ.Id;
            this.name = champ.Name;
            this.key = champ.Key;
            this.stats = AutoMapper.Mapper.Map<ChampStats>(champ.Stats);
            this.passive = new ChampionPassive(champ.Passive);
            this.championSpells = new List<ChampionSpell>();
            AutoMapper.Mapper.CreateMap<ImageDto, Image>();
            this.image = AutoMapper.Mapper.Map<Image>(champ.Image);
            foreach (var champSpell in champ.Spells)
            {
                championSpells.Add(new ChampionSpell(champSpell));
            }
            this.title = champ.Title;
        }
        public Champion()
        {

        }
    }
}
