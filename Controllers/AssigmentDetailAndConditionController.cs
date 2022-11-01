using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBookingProject.Models;
using TravelBookingProject.ViewModel;

namespace TravelBookingProject.Controllers
{
    
    public class AssigmentDetailAndConditionController : Controller
    {
        LoginContext db = new LoginContext();
        AssignmentDetailAndConditionViewModel assignmentObj;
        // GET: AssigmentDetailAndCondition
        public ActionResult Index()
        {
         
            return View();
        }
        [HttpGet]
        public ActionResult AssignmentDetailAndConditionForm()
        {
            assignmentObj = new AssignmentDetailAndConditionViewModel();
            assignmentObj.hostCountryList = new SelectList(db.Countries, "CountryId", "CountryName");

            assignmentObj.hostCityList = new SelectList(db.Cities, "CityId", "CityName");

            assignmentObj.checkList = new List<SelectListItem>()
            {
                 new SelectListItem { Text = "Yes", Value = "Yes" },
                new SelectListItem { Text = "No", Value = "No"}
            };
            return View(assignmentObj);
        }

        [HttpPost]
        public ActionResult AssignmentDetailAndConditionForm(AssignmentDetailAndConditionViewModel assignmentObj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    AssignmentDetailInfo detailObj = new AssignmentDetailInfo();
                    AssignmentConditionInfo conditionObj = new AssignmentConditionInfo();
                    string EmpId = Session["empid"].ToString();
                    detailObj.EmpId = EmpId;
                    detailObj.HomeCountryId = assignmentObj.HomeCountryId;  
                    detailObj.HomeCityId = assignmentObj.HomeCityId;
                    detailObj.HostCountryId = assignmentObj.HostCountryId;  
                    detailObj.HostCityId = assignmentObj.HostCityId;
                    detailObj.FromGBU = assignmentObj.FromGBU;
                    detailObj.ToGBU = assignmentObj.ToGBU;
                    detailObj.FromLegalEntity = assignmentObj.FromLegalEntity;
                    detailObj.ToLegalEntity = assignmentObj.ToLegalEntity;
                    detailObj.FromDivision = assignmentObj.FromDivision;
                    detailObj.ToDivision = assignmentObj.ToDivision;    
                    db.AssignmentDetailInfos.Add(detailObj);
                    db.SaveChanges();

                    
                    conditionObj.EmpId = EmpId;
                    conditionObj.Expected_Start_Date = assignmentObj.Expected_Start_Date;
                    conditionObj.Expected_End_Date = assignmentObj.Expected_End_Date;
                    conditionObj.Reason_Mobility_Request = assignmentObj.Reason_Mobility_Request;
                    conditionObj.Employee_Replacing_International_Employee = assignmentObj.Employee_Replacing_International_Employee;   
                    conditionObj.Employee_Reporting_To = assignmentObj.Employee_Reporting_To;   
                    conditionObj.Performance_review_done_by = assignmentObj.Performance_review_done_by;
                    conditionObj.Employee_Work_Full_Time_in_HostCountry = assignmentObj.Employee_Work_Full_Time_in_HostCountry; 
                    conditionObj.Employee_Work_not_Full_Time_then_Estimated_Work_Schedule = assignmentObj.Employee_Work_not_Full_Time_then_Estimated_Work_Schedule;
                    conditionObj.Employee_relationship_host_country = assignmentObj.Employee_relationship_host_country;
                    conditionObj.Why_local_employee_not_consider_for_this_position = assignmentObj.Why_local_employee_not_consider_for_this_position;
                    db.AssignmentConditionInfos.Add(conditionObj);
                    db.SaveChanges();

                    return RedirectToAction("ProjectDetailForm", "ProjectDetail");
                }
                catch (Exception ex)
                {

                    ViewBag.Error = ex.Message;
                    if (ex.InnerException != null)
                    {
                        ViewBag.Errormsg = ex.InnerException.InnerException.Message;
                    }
                    return View(assignmentObj); 
                }
               
            }
            return View(assignmentObj);
        }



        public JsonResult Cities(string countryId)
        {
            var cities = db.Cities.Where(x => x.CountryId == countryId).Select(m => new SelectListItem()
            {
                Text = m.CityName,
                Value = m.CityId.ToString(),
            });

            return Json(cities, JsonRequestBehavior.AllowGet);
        }

    }
}