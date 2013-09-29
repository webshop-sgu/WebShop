using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private Database db = new Database();

        public HomeController()
        {
        }

        public ActionResult Index()
        {
            ViewBag.ShowSearchBox = true;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
