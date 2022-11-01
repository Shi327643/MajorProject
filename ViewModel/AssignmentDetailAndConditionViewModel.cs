using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelBookingProject.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace TravelBookingProject.ViewModel
{
    public class AssignmentDetailAndConditionViewModel
    {
        
        public string EmpId { get; set; }
        [Required(ErrorMessage ="Home Country is Required")]
        public string HomeCountryId { get; set; }
        [Required(ErrorMessage = "Home City is Required")]
        public int HomeCityId { get; set; }
        [Required(ErrorMessage = "Host Country is Required")]
        public string HostCountryId { get; set; }
        [Required(ErrorMessage = "Host City Required")]
        public int HostCityId { get; set; }
        [Required(ErrorMessage = "From GBU is Required")]
        public string FromGBU { get; set; }
        [Required(ErrorMessage = "To GBU is Required")]
        public string ToGBU { get; set; }
        [Required(ErrorMessage = "From Legal Entity is Required")]
        public string FromLegalEntity { get; set; }
        [Required(ErrorMessage = "To Legal Entity is Required")]
        public string ToLegalEntity { get; set; }
        [Required(ErrorMessage = "From Division is Required")]
        public string FromDivision { get; set; }
        [Required(ErrorMessage = "To Division is Required")]
        public string ToDivision { get; set; }

        [Required(ErrorMessage = "Expected Start Date is Required")]
        [Display(Name = "Expected Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true/*, DataFormatString = "{0:yyyy-mmm-dd}"*/)]
        public DateTime Expected_Start_Date { get; set; }
        [Required(ErrorMessage = "Expected End Date is Required")]
        [Display(Name = "Expected End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true/*, DataFormatString = "{0:yyyy-mmm-dd}"*/)]
        public DateTime Expected_End_Date { get; set; }
        [Required(ErrorMessage = "Reason of Mobility Request is Required")]
        public string Reason_Mobility_Request { get; set; }
        [Required(ErrorMessage = "Employee Replacing International Employee is Required")]
        public string Employee_Replacing_International_Employee { get; set; }
       // public bool Employee_Replacing_International_Employee { get; set; }
        [Required(ErrorMessage = "Employee Reporting to is Required")]
        public string Employee_Reporting_To { get; set; }
        [Required(ErrorMessage = "Performance review done by is Required")]
        public string Performance_review_done_by { get; set; }
        [Required(ErrorMessage = "Employee Work Full Time in host country is Required")]
        public string Employee_Work_Full_Time_in_HostCountry { get; set; }
       // public bool Employee_Work_Full_Time_in_HostCountry { get; set; }
        [Required(ErrorMessage = "Estimated Woek Schedule is Required")]
        public string Employee_Work_not_Full_Time_then_Estimated_Work_Schedule { get; set; }
        [Required(ErrorMessage = "Employee relationship in host country is Required")]
        public string Employee_relationship_host_country { get; set; }
        [Required(ErrorMessage = "Why local employee not consider for this position is Required")]
        public string Why_local_employee_not_consider_for_this_position { get; set; }

        public IEnumerable<SelectListItem> hostCountryList { get; set; }
        public IEnumerable<SelectListItem> hostCityList { get; set; }

        public IList<SelectListItem> checkList { get; set; }

        public AssignmentDetailAndConditionViewModel()
        {
            checkList = new List<SelectListItem>(); 
        }
    }
}