using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.Configuration;
using System.Data;
namespace Itemise_It.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }
    }
}