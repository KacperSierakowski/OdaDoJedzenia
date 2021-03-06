﻿using Nauka3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nauka3.Controllers
{
    public class HomeController : Controller
    {
        OdaDoJedzeniaDb _db = new OdaDoJedzeniaDb();

        public ActionResult Index(string searchTerm=null)
        {
            //var model = from r in _db.Restaurants
            //            //orderby r.Name ascending//nazwa
            //            //orderby r.Reviews.Count() descending//ilosc ocen
            //            orderby r.Reviews.Average(review=>review.Rating) descending//najlepsze oceny
            //            select new RestaurantsListViewModel
            //            {
            //                Id=r.Id,
            //                Name=r.Name,
            //                City=r.City,
            //                Country=r.Country,
            //                CountOfReviews= r.Reviews.Count()
            //            };//_db.Restaurants.ToList();
            var model =
                _db.Restaurants
                .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                .Where(r=>searchTerm==null||r.Name.StartsWith(searchTerm))
                .Take(10)
                .Select(r => new RestaurantsListViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    City = r.City,
                    Country = r.Country,
                    CountOfReviews = r.Reviews.Count()
                });


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
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}