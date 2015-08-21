using Newtonsoft.Json;
using RiotApiDAL.ItemSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Itemise_It.Controllers
{
    public class ItemSetsController : Controller
    {
        // GET: ItemSets
        public ActionResult Index()
        {

            return View(new ItemSet());
        }
        public FileResult Download()
        {
            ItemSet set = new ItemSet();
            set.init("global", "any", "any",
                new List<Block> {
                    new Block("ItemSet1", new List<Item> {
                        new Item(1001.ToString(), 0),
                        new Item(1001.ToString(), 0)})},"FirstItemSet");
            var serializer = new Newtonsoft.Json.JsonSerializer();
            byte[] result = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(set, Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));

            return File(result, "application/json", $"{set.title}.json");
        }
    }
}