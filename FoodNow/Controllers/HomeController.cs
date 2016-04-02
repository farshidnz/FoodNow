using FoodNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodNow.Controllers
{
    public class HomeController : Controller
    {
        FoodNowDb _db = new FoodNowDb();
        public ActionResult Index(string searchTerm = null)
        {
            var model = _db.Restaurants.Where(r => searchTerm == null || r.Suburb.Equals(searchTerm))
                .Take(10).ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}