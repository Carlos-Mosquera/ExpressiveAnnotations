﻿using System.Web.Mvc;
using ExpressiveAnnotations.MvcWebSample.Models;

namespace ExpressiveAnnotations.MvcWebSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new Query {SportType = "Extreme"};
            return View("Home", model);
        }

        [HttpPost]
        public ActionResult Index(Query model)
        {
            if (ModelState.IsValid)
            {
                return View("Success");
            }
            return View("Home", model);
        }

        public ActionResult Help()
        {
            return View("Help");
        }
    }
}