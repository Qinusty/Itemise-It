using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApiDAL.ItemSets
{
    public class ItemSet
    {
        /// <summary>
        /// The name of the item set as you would see it in the drop down.
        /// </summary>
        [JsonProperty]
        public string title { get; private set; }

        /// <summary>
        /// Can be custom or global. This field is only used for grouping and sorting item sets. Custom item sets are ordered above global item sets. This field does not govern whether an item set available for every champion. To make an item set available for every champion, the JSON file must be placed an item set in the global folder.
        /// </summary>
        [JsonProperty]
        [JsonRequired]
        string type { get; set; }
        /// <summary>
        /// The map this item set will appear on. Can be any, Summoner's Rift SR, Howling Abyss HA, Twisted Treeline TT, or Crystal Scar CS.
        /// </summary>
        [JsonProperty]
        [JsonRequired]
        string map { get; set; }
        /// <summary>
        /// The mode this item set will appear on. Can be any, CLASSIC, ARAM, or Dominion ODIN.
        /// </summary>
        [JsonProperty]
        [JsonRequired]
        string mode { get; set; }
        /// <summary>
        /// Selectively sort this item set above other item sets. Overrides sortrank, but not type. Defaults to false.
        /// </summary>
        [JsonProperty]
        bool priority { get; set; }

        [JsonProperty]
        object sortrank { get; set; }

        [JsonProperty]
        [JsonRequired]
        List<Block> blocks { get; set; }

        public void init(string _type, string _map, string _mode, List<Block> _blocks, string _title = null, bool _priority = false, object _sortrank = null)
        {
            type = _type;
            map = _map;
            mode = _mode;
            blocks = _blocks;
            title = _title;
            priority = _priority;
            sortrank = _sortrank;
        }
        public ItemSet()
        {

        }
    }
}
