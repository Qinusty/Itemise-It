using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotApi.Net.RestClient.Dto.LolStaticData.Item;
using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;

namespace RiotApiDAL.Static.Item
{
    public class Item
    {
        public Item(ItemDto value)
        {
            AutoMapper.Mapper.CreateMap<BasicDataStatsDto, ItemStats>();
            this.stats = AutoMapper.Mapper.Map<ItemStats>(value.Stats);
            this.name = value.Name;
            this.plainText = value.Plaintext;
            this.sanitizedDescription = value.SanitizedDescription;
            this.requiredChampion = value.RequiredChampion;
            this.id = value.Id;
            if (value.Maps != null)
            {
                this.maps = string.Join(";", value.Maps.Values.ToList());
            }
            if (value.Tags != null)
            {
                this.tags = string.Join(";", value.Tags);
            }
            if (value.Image != null)
            {
                this.image = AutoMapper.Mapper.Map<Image>(value.Image);
            }
            if (value.Gold != null)
            {
                this.purchasable = value.Gold.Purchasable;
                this.sellPrice = value.Gold.Sell;
                this.completionPrice = value.Gold.Base;
                this.totalCost = value.Gold.Total;
            }
            if (value.From != null)
            {
                this.buildsFrom = string.Join(";", value.From);
            }
            if (value.Into != null)
            {
                this.buildsInto = string.Join(";", value.Into);
            }
        }
        public Item()
        {
        }


        [Key]
        [Required]
        public int id { get; set; }

        public string name { get; set; }

        public string plainText { get; set; }

        public string sanitizedDescription { get; set; }

        public string buildsFrom { get; set; }

        public string buildsInto { get; set; }

        public virtual ItemStats stats { get; set; }

        public string requiredChampion { get; set; }

        public string maps { get; set; }
        
        public string tags { get; set; }

        public virtual Image image { get; set; }

        public int totalCost { get; set; }
        
        public bool purchasable { get; set; }

        public int sellPrice { get; set; }

        public int completionPrice { get; set; }
    }
    
}
