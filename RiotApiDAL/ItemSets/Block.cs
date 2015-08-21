using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApiDAL.ItemSets
{
    public class Block
    {
        /// <summary>
        /// The name of the block as you would see it in the item set.
        /// </summary>
        [JsonProperty]
        [JsonRequired]
        string type { get; set; }
        /// <summary>
        /// Use the tutorial formatting when displaying items in the block. All items within the block are separated by a plus sign with the last item being separated by an arrow indicating that the other items build into the last item. Defaults to false.
        /// </summary>
        [JsonProperty]
        bool recMath { get; set; }
        /// <summary>
        /// The minimum required account level for the block to be visible to the player. Defaults to -1 which is equivalent to "any account level."
        /// </summary>
        [JsonProperty]
        int minSummonerLevel { get; set; }
        /// <summary>
        /// The maximum allowed account level for the block to be visible to the player. Defaults to -1 which is equivalent to "any account level."
        /// </summary>
        [JsonProperty]
        int maxSummonerLevel { get; set; }
        /// <summary>
        /// Only show the block if the player has equipped a specific summoner spell. Can be any valid summoner spell key, e.g. SummonerDot. Defaults to an empty string. Will not override hideIfSummonerSpell.
        /// </summary>
        [JsonProperty]
        
        string showIfSummonerSpell { get; set; }
        /// <summary>
        /// Hide the block if the player has equipped a specific summoner spell. Can be any valid summoner spell key, e.g. SummonerDot. Defaults to an empty string. Overrides showIfSummonerSpell.
        /// </summary>
        [JsonProperty]
        string hideIfSummonerSpell { get; set; }
        /// <summary>
        /// An List of items to be displayed within the block.
        /// </summary>
        [JsonProperty]
        [JsonRequired]
        List<Item> items { get; set; }

        public Block(string _type, List<Item> _items, bool _recMath = false, int _minSummonerLevel = -1, 
            int _maxSummonerLevel = -1, string _showIfSummonerSpell = null, string _hideIfSummonerSpell = null)
        {
            type = _type;
            items = _items;
            recMath = _recMath;
            minSummonerLevel = _minSummonerLevel;
            maxSummonerLevel = _maxSummonerLevel;
            showIfSummonerSpell = _showIfSummonerSpell;
            hideIfSummonerSpell = _hideIfSummonerSpell;
        }
    }
}
