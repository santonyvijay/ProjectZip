using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectZip.Controllers
{
    public class DepartmentController : Controller
    {
        ProjectZDepartmentEntities db = new ProjectZDepartmentEntities();
        //
        // GET: /Department/
        public ActionResult Index()
        {

            return View(db.College_Master.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new College_Master());
        }
        [HttpPost]
        public ActionResult Create(College_Master college)
        {
            if (ModelState.IsValid)
            {
                db.College_Master.Add(college);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(college);
            }
        }

        

	}
}