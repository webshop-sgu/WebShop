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
            ViewBag.Roles = db.Roles.ToList();
            ViewBag.Users = db.Users.ToList();
            ViewBag.RoleAsManager = db.Roles.Where(r => r.Id == 2).First();
            ViewBag.Categories = db.Categories.ToList();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
