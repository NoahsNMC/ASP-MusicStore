using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string About()
        {
            //ViewBag.Message = "Your application description page.";

            return "Noah Osterhout";
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("About");
        }

        public string Browse(int id)
        {
            return "ID:"+id;
        }
    }
}