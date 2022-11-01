using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBookingProject.Models;
using TravelBookingProject.ViewModel;

namespace TravelBookingProject.Controllers
{
    public class EmployeeChildrenInfoController : Controller
    {
        LoginContext db = new LoginContext();   
        // GET: EmployeeChildrenInfo
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EmployeeChildrenInfoForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmployeeChildrenInfoForm(EmployeeChildrenInfoViewModel childrenInfoObj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    EmployeeChildrenInfo childrenObj = new EmployeeChildrenInfo();

                    string EmpId = Session["empid"].ToString();
                    childrenObj.EmpId = EmpId;
                    childrenObj.ChildrenName = childrenInfoObj.ChildrenName;
                    childrenObj.ChildDateOfBirth = childrenInfoObj.ChildDateOfBirth;
                    childrenObj.PrimaryCitizenship = childrenInfoObj.PrimaryCitizenship;
                    childrenObj.Dependent_for_tax_purpose_in_home_country = childrenInfoObj.Dependent_for_tax_purpose_in_home_country;
                    db.EmployeeChildInfos.Add(childrenObj);
                    db.SaveChanges();

                    ModelState.Clear();
                    return View();



                    
                   
                   
                  
                  

                }
                catch (Exception ex)
                {


                    ViewBag.Error = ex.Message;
                    if (ex.InnerException != null)
                    {
                        ViewBag.Errormsg = ex.InnerException.InnerException.Message;
                    }
                    return View(childrenInfoObj);
                }
            }
            return View(childrenInfoObj);
        }
        [HttpPost]
        public ActionResult Submit()
        {
            return RedirectToAction("Welcome", "EmployeeAndFamily");
        }
         
    }
}