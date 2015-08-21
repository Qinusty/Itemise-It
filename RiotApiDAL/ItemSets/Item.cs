using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApiDAL.ItemSets
{
    public class Item
    {
        /// <summary>
        /// Item ID
        /// </summary>
        [JsonProperty]
        [JsonRequired]
        string id { get; set; }
        /// <summary>
        /// The number of times this item should be purchased. The count is displayed in the bottom right of the item icon. The indicator counts down whenever the item is purchased. If the count reaches 0 the item will show a check mark indicating the item has been completed. Defaults to 0.
        /// </summary>
        [JsonProperty]
        int count { get; set; }

        public Item(string _id, int _count = 0)
        {
            id = _id;
            count = _count;
        }
    }
}
