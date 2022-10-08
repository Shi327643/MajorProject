using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBookingProject.Models;

namespace TravelBookingProject.Controllers
{
   
    public class LoginPageController : Controller
    {
        LoginContext db = new LoginContext();
        // GET: LoginPage
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Validate()
        {
            return View();
        }
        public ActionResult ValidationConfirmation(UserLogin user)
        {
            if (ModelState.IsValid)
            {
                var query = (from e in db.UserLogins where e.UserName == user.UserName && e.Password == user.Password select e).Count();
                
                if (query > 0)
                {
                    return RedirectToAction("WelcomePage");
                }
                else
                {
                    // ViewBag.Message = "Invalid Username or Password";
                    ModelState.AddModelError("name", "Invalid UserName or Password.");
                    return View("Validate", user);
                }

            }
            return View("Validate", user);

        }

        public ActionResult WelcomePage()
        {
            return View();
        }
    }
}