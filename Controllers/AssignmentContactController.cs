using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBookingProject.Models;
using TravelBookingProject.ViewModel;

namespace TravelBookingProject.ViewModel
{
    public class AssignmentContactController : Controller
    {
        LoginContext db = new LoginContext();
        //AssignmentContactController assignmantContactObj;
        // GET: AssignmentContact
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AssignmentContactForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AssignmentContactForm(AssignmentContactViewModel assignmantContactObj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    AssignmentContactInfo contactObj = new AssignmentContactInfo();
                    contactObj.BudgetHolderName = assignmantContactObj.BudgetHolderName;
                    string EmpId = Session["empid"].ToString();
                    contactObj.EmpId = EmpId;
                    contactObj.BudgetHolder_Email = assignmantContactObj.BudgetHolder_Email;
                    contactObj.Home_HR_Director_Name = assignmantContactObj.Home_HR_Director_Name;
                    contactObj.Home_HR_Director_Email = assignmantContactObj.Home_HR_Director_Email;
                    contactObj.Home_Line_Manager_Name = assignmantContactObj.Home_Line_Manager_Name;
                    contactObj.Home_Line_Manager_Email = assignmantContactObj.Home_Line_Manager_Email;
                    contactObj.Host_HR_Director_Name = assignmantContactObj.Host_HR_Director_Name;
                    contactObj.Host_HR_Director_Email = assignmantContactObj.Host_HR_Director_Email;
                    contactObj.Host_Line_Manager_Name = assignmantContactObj.Host_Line_Manager_Name;
                    contactObj.Host_Line_Manager_Email = assignmantContactObj.Host_Line_Manager_Email;

                    db.AssignmentContactInfos.Add(contactObj);
                    db.SaveChanges();
                    return RedirectToAction("EmployeeAndFamilyInfoForm", "EmployeeAndFamily");
                }
                catch (Exception ex)
                {

                    ViewBag.Error = ex.Message;
                    if (ex.InnerException != null)
                    {
                        ViewBag.Errormsg = ex.InnerException.InnerException.Message;
                    }
                    return View(assignmantContactObj); ;
                }
            }
            return View(assignmantContactObj);
        }
    }
}