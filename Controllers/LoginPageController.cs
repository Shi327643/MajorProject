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
                var query = (from e in db.UserLogins where e.UserName == user.UserName && e.Password == user.Password select new {e.EmpId}).Count();
                
                if (query > 0)
                {


                    // string url = string.Format("/LoginPage/Booking?username={0} & password ={1}", user.UserName, user.Password);

                    //TempData["mydata"] = user.UserName;

                    Session["username"] = query;

                    return RedirectToAction("Booking");
                    
                }
                else
                {
                    // ViewBag.Message = "Invalid Username or Password";
                    ModelState.AddModelError("name", "Invalid UserName or Password.");
                    // Response.Redirect("Booking.aspx?username=" + Server.UrlEncode(user.UserName) + "&password=" + Server.UrlEncode(user.Password));
                   

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
           // ;
           
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
            //string username = Server.UrlDecode(Request.QueryString["username"].ToString());
            // string password = Server.UrlDecode(Request.QueryString["password"].ToString());
          
            //model.UserName = Request.QueryString["username"];
            //model.Password = Request.QueryString["password"];
            string username = (string)Session["username"];
           // string password = model.Password;
            var data = (from e in db.Employees
                        join u in db.UserLogins on e.EmpId equals u.EmpId
                        where u.UserName == username 
                        select new { e.EmpName, e.Country, e.City }).SingleOrDefault();
            
            string EmpName  = model.EmpName;
            string Country = model.Country;
            string City =      model.City;

            string value1 = data.EmpName;
            string value2 = data.Country;
            string value3 = data.City;
            string value4 = model.Status;

            EmpName = value1;
            Country = value2;
            City = value3;
            string Status = value4;   
            Status = "Pending";
            model.GCMItem = new SelectList(db.GCMs, "GCMId", "GCM_Level");
            model.TravelItem = new SelectList(db.Travels, "TravelId", "Travel_Type");

            //IEnumerable<SelectListItem> value = db.GCMs.Select(x=> new SelectListItem
            //{
            //    Value = x.GCMId.ToString(),
            //    Text = x.GCM_Level
            //});
            //ViewBag.List = value;

            //var items = new TravelViewModel()
            //{
            //    GCMId = model.GCMId,
            //    GCM_Level = model.GCM_Level,

            //    GCMs = db.GCMs.Select(x => new SelectListItem
            //    {
            //        Value = x.GCMId.ToString(),
            //        Text = x.GCM_Level
            //    })
            //};



            // model.GCMList = (IList<GCM>)items;




            ViewBag.data = EmpName;
            ViewBag.data1 = Country;
            ViewBag.data2 = City;
            ViewBag.data3 = Status;
           
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



        //public ActionResult Booking(TravelViewModel model)
        //{


        //                    //if (username == null)
        //                    //{
        //                    //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);// 400
        //                    //}
        //                    //UserLogin login = db.UserLogins.Find(username); //Search for recod by id
        //                    //if (login == null)// Emp not found by id
        //                    //{
        //                    //    return HttpNotFound(); //404

        //                    //}
        //    return View(model);
        //}

        //public ActionResult Booking(UserLogin login, Employee emp,Travelers travel)
        //{
        //    //if (ModelState.IsValid)
        //    //{
        //    //    try
        //    //    {
        //    //        db.Entry<Employee>(emp).State = System.Data.Entity.EntityState.Modified;
        //    //        db.UserLogins.Add(login);
        //    //        db.SaveChanges();
        //    //        return RedirectToAction("DisplayTravelers");


        //    //    }
        //    //    catch (Exception ex)
        //    //    {

        //    //        ViewBag.Error = ex.Message;
        //    //        if (ex.InnerException != null)
        //    //        {
        //    //            ViewBag.Errormsg = ex.InnerException.InnerException.Message;
        //    //        }
        //    //        return View(emp); 
        //    //    }
        //    //}




        //    return View(emp); 
        //}


        //var data = (from e in db.Employees
        //            join u in db.UserLogins on e.EmpId equals u.EmpId
        //            where u.UserName == login.UserName && u.Password == login.Password
        //            select new { e.EmpName, e.Country, e.City });
    }
}