using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T_GuideMe.Models;

namespace T_GuideMe.Controllers
{
    public class StudentController : Controller
    {
        Entities db = new Entities();
        // GET: Student
        public ActionResult Index()
        {
         
                return View();

           
        }
    }
}