using MovieRentDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var c = new movierent();
            ViewBag.Title = "Home Page";

            return View(c.Movies);
        }
    }
}
