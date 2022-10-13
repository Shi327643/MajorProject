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
        TravelViewModel model;
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
                    

                    return RedirectToAction("Booking");
                    
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
        public ActionResult DisplayTravelers()
        {
            TravelViewModel travelObj = new TravelViewModel();
            var data = db.Travelers.ToList();
            travelObj.travlersList = data;
            return View(travelObj);
        }
        [HttpGet]
        
        public ActionResult Booking()
        {
             model = new TravelViewModel();

            string EmpId = Session["empid"].ToString();
            var data = (from e in db.Employees
                        join u in db.UserLogins on e.EmpId equals u.EmpId
                        where u.EmpId == EmpId 
                        select new { e.EmpName, e.Country, e.City }).SingleOrDefault();
            

            model.EmpName = data.EmpName;
            model.Country = data.Country;
            model.City = data.City;
            model.Status = "Pending";
            model.GCMItem = new SelectList(db.GCMs, "GCMId", "GCM_Level");
            model.TravelItem = new SelectList(db.Travels, "TravelId", "Travel_Type");


           
            return View(model);
        }
        [HttpPost]
        public ActionResult Booking(TravelViewModel model)
        {
            if (ModelState.IsValid) 
            {
                try
                {
                    db.Travelers.Add(model.Travelers);            
                    db.SaveChanges();
                    return RedirectToAction("DisplayTravelers");
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                    if (ex.InnerException != null)
                    {
                        ViewBag.Errormsg = ex.InnerException.InnerException.Message;
                    }
                    return View(model);

                }
                
            }
            return View(model);

        }

    }
}