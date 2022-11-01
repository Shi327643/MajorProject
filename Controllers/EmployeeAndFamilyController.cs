using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBookingProject.Models;
using TravelBookingProject.ViewModel;

namespace TravelBookingProject.Controllers
{
    public class EmployeeAndFamilyController : Controller
    {
        LoginContext db = new LoginContext();
        EmployeeAndFamilyViewModel employeeAndFamilyObj; 
        // GET: EmployeeAndFamily
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult EmployeeAndFamilyInfoForm()
        {
            if (Session["empid"] == null)
            {
                return HttpNotFound();
            }
            employeeAndFamilyObj =  new EmployeeAndFamilyViewModel();
            employeeAndFamilyObj.GCMItem = new SelectList(db.GCMs, "GCMId", "GCM_Level");
           

            return View(employeeAndFamilyObj);
        }
        [HttpPost]
        public ActionResult EmployeeAndFamilyInfoForm(EmployeeAndFamilyViewModel employeeAndFamilyObj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    EmployeePersonalInfo personalInfo = new EmployeePersonalInfo();
                    EmployeeFamilyInfo familyInfo = new EmployeeFamilyInfo();
                  
                    string EmpId = Session["empid"].ToString();
                    personalInfo.EmpId = EmpId;
                    personalInfo.LastName = employeeAndFamilyObj.LastName;
                    personalInfo.FirstName = employeeAndFamilyObj.FirstName;    
                    personalInfo.Gender = employeeAndFamilyObj.Gender;
                    personalInfo.DasId = employeeAndFamilyObj.DasId;
                    personalInfo.Email = employeeAndFamilyObj.Email;
                    personalInfo.DateOfBirth = employeeAndFamilyObj.DateOfBirth;    
                    personalInfo.PrimaryCitizenship = employeeAndFamilyObj.PrimaryCitizenship;
                    personalInfo.SecondaryCitizenship = employeeAndFamilyObj.SecondaryCitizenship;
                    personalInfo.GCM_Id_Home_Country = employeeAndFamilyObj.GCM_Id_Home_Country;  
                    personalInfo.GCM_Id_Host_Country = employeeAndFamilyObj.GCM_Id_Host_Country;  

                    db.EmployeePersonalInfos.Add(personalInfo);
                    db.SaveChanges();

                    familyInfo.EmpId = EmpId;
                    familyInfo.Family_Status_Home_Country = employeeAndFamilyObj.Family_Status_Home_Country;
                    familyInfo.Family_Host_Country = employeeAndFamilyObj.Family_Host_Country;      
                    familyInfo.Spouse_Location = employeeAndFamilyObj.Spouse_Location;    

                    db.EmployeeFamilyInfos.Add(familyInfo);
                    db.SaveChanges();
                    return RedirectToAction("EmployeeChildrenInfoForm", "EmployeeChildrenInfo");

                   
                }
                catch (Exception ex)
                {

                    ViewBag.Error = ex.Message;
                    if (ex.InnerException != null)
                    {
                        ViewBag.Errormsg = ex.InnerException.InnerException.Message;
                    }
                    return View(employeeAndFamilyObj);
                }
            }
            return View(employeeAndFamilyObj);
        }

        


        public ActionResult Welcome()
        {
            ViewBag.message = "Your Response has been submitted";
            return View();
        }
    }
}