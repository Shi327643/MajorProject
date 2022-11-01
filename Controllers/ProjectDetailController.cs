using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBookingProject.Models;
using TravelBookingProject.ViewModel;

namespace TravelBookingProject.Controllers
{
    public class ProjectDetailController : Controller
    {
        LoginContext db = new LoginContext();
        
        // GET: ProjectDetail
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ProjectDetailForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProjectDetailForm(ProjectDetailViewModel projectDetailObj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ProjectDetailInfo projectObj = new ProjectDetailInfo();
                    projectObj.Role_in_Host_Country = projectDetailObj.Role_in_Host_Country;
                    string EmpId = Session["empid"].ToString();
                    projectObj.EmpId = EmpId;
                    projectObj.Role_description_Host_Country = projectDetailObj.Role_description_Host_Country;
                    projectObj.Annual_base_Salary = projectDetailObj.Annual_base_Salary;
                    projectObj.Worldline_Entity_name_bearing_costs = projectDetailObj.Worldline_Entity_name_bearing_costs;
                    projectObj.worldline_costs_centre_bearing_costs = projectDetailObj.worldline_costs_centre_bearing_costs;
                    projectObj.Client_name_for_whome_Employee_Working = projectDetailObj.Client_name_for_whome_Employee_Working;
                    projectObj.Project_name_on_which_Employee_Working = projectDetailObj.Project_name_on_which_Employee_Working;
                    projectObj.Nature_of_Activity = projectDetailObj.Nature_of_Activity;
                    projectObj.Worldline_recruitment = projectDetailObj.Worldline_recruitment;

                    db.ProjectDetailInfos.Add(projectObj);
                    db.SaveChanges();
                    return RedirectToAction("AssignmentContactForm", "AssignmentContact");
                }
                catch (Exception ex)
                {

                    ViewBag.Error = ex.Message;
                    if (ex.InnerException != null)
                    {
                        ViewBag.Errormsg = ex.InnerException.InnerException.Message;
                    }
                    return View(projectDetailObj); 
                }
            }
            return View(projectDetailObj);
            
        }
    }
}