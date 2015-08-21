using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotApi.Net.RestClient;

namespace RiotApiDAL.Static
{
    public class Patch
    {
        [Key]
        [Required]
        public int id { get; set; }

        public string version { get; set; }

        public virtual ICollection<Champion.Champion> Champions { get; set; }

        public virtual ICollection<Item.Item> Items { get; set; }

        public DateTime Added { get; set; }

        public Patch(RiotApi.Net.RestClient.Dto.LolStaticData.Champion.ChampionListDto champList, 
            RiotApi.Net.RestClient.Dto.LolStaticData.Item.ItemListDto itemList)
        {
            this.version = champList.Version;
            Champions = new List<Champion.Champion>();
            Items = new List<Item.Item>();
            foreach (var champ in champList.Data)
            {
                Champions.Add(new Champion.Champion(champ.Value));
            }
            foreach (var item in itemList.Data)
            {
                Items.Add(new Item.Item(item.Value));
            }
            Added = DateTime.UtcNow;
            
        }
        public Patch()
        {

        }
    }
}
