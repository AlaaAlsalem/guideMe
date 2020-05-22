using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T_GuideMe.Controllers
{
    public class SelectController : Controller
    {
        // GET: Select
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ToStudent()
        {
            return RedirectToAction("Index", "Student");
        }
        public ActionResult ToTeacher()
        {
            return RedirectToAction("Index", "Teacher");
        }
    }
}