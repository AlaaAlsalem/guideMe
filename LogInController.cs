using System.Linq;
using System.Web.Mvc;
using T_GuideMe.Models;

namespace T_GuideMe.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
      
            Entities db = new Entities();

        public ActionResult Index()
        {


            return View();
        }
        [HttpPost]

        public ActionResult Autherize(User userModel)
        {
            var studentDetails = db.Users.Where(x => x.userName == userModel.userName && x.Password == userModel.Password).FirstOrDefault();
            if (studentDetails != null)
            {
                if (studentDetails.Type == "Admin")
                {
                    return RedirectToAction("Index", "Admin");

                }
                


                return RedirectToAction("Index", "Select");
                Session["id"] = studentDetails.Id.ToString();
            }
            return View("Index");



        }
        //
        // POST: /Account/Login




    }

}