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

        public ActionResult Autocomplete(string term)
        {
            var model = _db.Restaurants.Where(r => r.Suburb.StartsWith(term)).Take(7).Select(r => new { label = r.Suburb }).Distinct();
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index(string searchTerm = null)
        {
            if (searchTerm != null)
            {
                var model = _db.Restaurants.Where(r => searchTerm == null || r.Suburb.Equals(searchTerm))
                    .Take(10).ToList();
                if (Request.IsAjaxRequest())
                {
                    return PartialView("_Restaurants", model);
                }
                return View(model);
            }
            var emptyModel = new List<Restaurant>();
            return View(emptyModel);
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