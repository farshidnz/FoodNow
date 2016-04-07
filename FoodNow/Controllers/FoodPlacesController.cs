using FoodNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodNow.Controllers
{
    public class FoodPlacesController : Controller
    {
        FoodNowDb _db = new FoodNowDb();
        // GET: FoodPlaces
        public ActionResult DisplayPlaces(string searchTerm = null)
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

        public ActionResult EditSearch(List<Restaurant> model)
        {
            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}