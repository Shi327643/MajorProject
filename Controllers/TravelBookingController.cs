using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TravelBookingProject.Models;
using TravelBookingProject.ViewModel;
namespace TravelBookingProject.Controllers
{
    
    public class TravelBookingController : Controller
    {
        TravelViewModel model;
        LoginContext db = new LoginContext();
        // GET: TravelBooking
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DisplayTravelers()
        {
            TravelViewModel travelObj = new TravelViewModel();
            var data = db.Travelers.ToList();
            travelObj.travlersList = data;
            return View(travelObj);
        }
        [HttpGet]
        public ActionResult TravelBooking()
        {
            model = new TravelViewModel();

            string EmpId = Session["empid"].ToString();
            var data = (from e in db.Employees
                        join u in db.UserLogins on e.EmpId equals u.EmpId
                        where u.EmpId == EmpId
                        select new { e.EmpName, e.Country, e.City,e.ManagerId}).SingleOrDefault();


            model.EmpName = data.EmpName;
            model.Country = data.Country;
            model.City = data.City;
            model.ManagerId = data.ManagerId;
            
            model.Status = "Pending";
            model.GCMItem = new SelectList(db.GCMs, "GCMId", "GCM_Level");
            model.TravelItem = new SelectList(db.Travels, "TravelId", "Travel_Type");
         



            return View(model);
        }
        [HttpPost]
        public ActionResult TravelBooking(TravelViewModel model)
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
        public JsonResult Cities(string countryId)
        {
            var cities = db.Cities.Where(x=>x.CountryId==countryId).Select(m=> new SelectListItem()
            {
                Text = m.CityName,
                Value = m.CityId.ToString(),
            });

            return Json(cities, JsonRequestBehavior.AllowGet);
        }
    }
}