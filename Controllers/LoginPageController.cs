using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TravelBookingProject.Models;
using TravelBookingProject.ViewModel;

namespace TravelBookingProject.Controllers
{
    


    public class LoginPageController : Controller
    {
        //TravelViewModel model;
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
                var query = (from e in db.UserLogins where e.UserName == user.UserName && e.Password == user.Password select new {e.EmpId}).SingleOrDefault();
                Session["empid"] = query.EmpId;

                if (query!=null)
                {
                    

                    return RedirectToAction("TravelBooking","TravelBooking");
                    
                }
                else
                {
                    
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

        public ActionResult DisplayEmployee()
        {
            TravelViewModel travelObj = new TravelViewModel();
            var data = db.Employees.ToList();
            travelObj.EmpList = data;

            return View(travelObj);

        }
        public ActionResult UserLoginPage(UserLogin login)
        {
            TravelViewModel travelObj = new TravelViewModel();
            var data = db.UserLogins.ToList();
            travelObj.userList = data;
         
           
            return View(travelObj);

        }
        public ActionResult DisplayCountry()
        {
            TravelViewModel travelObj = new TravelViewModel();
            var data = db.Countries.ToList();
            travelObj.countryList = data;
            return View(travelObj);
        }
        public ActionResult DisplayCity()
        {
            TravelViewModel travelObj = new TravelViewModel();
            var data = db.Cities.ToList();
            travelObj.cityList = data;
            return View(travelObj);
        }
        public ActionResult DisplayGCMLevel()
        {
            TravelViewModel travelObj = new TravelViewModel();
            var data = db.GCMs.ToList();
            travelObj.GCMList = data;
            return View(travelObj);
        }
        public ActionResult DisplayTravelType()
        {
            TravelViewModel travelObj = new TravelViewModel();
            var data = db.Travels.ToList();
            travelObj.travelList = data;
            
            return View(travelObj);
        }
       
       
        
        

    }
}