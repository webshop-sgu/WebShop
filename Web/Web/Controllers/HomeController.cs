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
        private DatabaseContext db = new DatabaseContext();

        public HomeController()
            : base()
        {
        }

        public ActionResult Index()
        {
            ViewBag.ShowSearchBox = true;
            return View(db.Roles.ToList());
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
