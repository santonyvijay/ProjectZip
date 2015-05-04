using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectZip.Models;
namespace ProjectZip.Controllers
{
    public class CollegeController : Controller
    {
       
        public ActionResult Index(string id)
        {
            CollegeContext collegeContext = new CollegeContext();
            College college = collegeContext.College.Single(clg => clg.College_Code == id);
            

            return View(college);
        }
	}
}