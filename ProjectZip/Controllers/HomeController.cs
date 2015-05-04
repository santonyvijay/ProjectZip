using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectZip.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "You are in About page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You are in Contact page.";

            return View();
        }

        public ActionResult Department()
        {
            ViewBag.Message = "You are in Department page.";

            return View();
        }


        
        public ActionResult Course()
        {
            ViewBag.Message = "Please Enter Course Data.";

            return View();
        }

        public ActionResult Programs()
        {
            ViewBag.Message = "Please Enter Programs Data";

            return View();
        }
    }
}