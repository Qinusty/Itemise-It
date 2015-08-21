using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;

namespace RiotApiDAL.Static.Champion
{
    public class ChampionPassive
    {
        

        public ChampionPassive(PassiveDto passive)
        {
            this.description = passive.Description;
            this.sanitizedDescription = passive.SanitizedDescription;
            this.name = passive.Name;
            AutoMapper.Mapper.CreateMap<ImageDto, Image>();
            this.image = AutoMapper.Mapper.Map<Image>(passive.Image);
        }
        public ChampionPassive()
        {

        }

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string description { get; set; }

        public string sanitizedDescription { get; set; }

        public string name { get; set; }

        public virtual Image image { get; set; }

    }
}
