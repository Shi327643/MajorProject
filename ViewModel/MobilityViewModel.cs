using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBookingProject.Models;

namespace TravelBookingProject.ViewModel
{
    public class MobilityViewModel
    {
        public string EmpId { get; set; }
        public string HomeCountryId { get; set; }
        public int HomeCityId { get; set; }
        public string HostCountryId { get; set; }
        public string HostCityId { get; set; }
        public string FromGBU { get; set; }
        public string ToGBU { get; set; }
        public string FromLegalEntity { get; set; }
        public string ToLegalEntity { get; set; }
        public string FromDivision { get; set; }
        public string Todivision { get; set; }

        [Required]
        [Display(Name = "Expected Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true/*, DataFormatString = "{0:yyyy-mmm-dd}"*/)]
        public DateTime Expected_Start_Date { get; set; }

        [Required]
        [Display(Name = "Expected End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true/*, DataFormatString = "{0:yyyy-mmm-dd}"*/)]
        public DateTime Expected_End_Date { get; set; }
        public string Reason_Mobility_Request { get; set; }
        public string Employee_Replacing_International_Employee { get; set; }
        public string Employee_Reporting_To { get; set; }
        public string performance_review_done_by { get; set; }
        public string Employee_Work_Full_Time_in_HostCountry { get; set; }
        public string Employee_Work_Full_Time_Then_Estimated_Work_Schdule { get; set; }
        public string Employee_relationship_host_country { get; set; }
        public string Why_local_employee_not_consider_for_this_position { get; set; }
        public string Role_in_Host_Country { get; set; }
        public string Role_description_Host_Country { get; set; }
        public decimal Annual_base_Salary { get; set; }
        public string Worldline_Entity_name_bearing_costs { get; set; }
        public string Worldline_costs_center_bearing_costs { get; set; }
        public string Client_name_for_whome_Employee_Working { get; set; }
        public string Project_name_on_which_Employee_Working { get; set; }
        public string Nature_of_Activity { get; set; }
        public string Worldline_recruitement { get; set; }
        public string BudgetHolderName { get; set; }

        [Required(ErrorMessage = "email is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.]+@([a-zA-Z0-9]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "email is not valid")]
        public string BudgetHolder_Email { get; set; }
        public string Home_HR_Director_Name { get; set; }

        [Required(ErrorMessage = "email is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.]+@([a-zA-Z0-9]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "email is not valid")]
        public string Home_HR_Director_Email { get; set; }
        public string Home_Line_Manager_Name { get; set; }

        [Required(ErrorMessage = "email is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.]+@([a-zA-Z0-9]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "email is not valid")]
        public string Home_Line_Manager_Email { get; set; }
        public string Host_HR_Director_Name { get; set; }

        [Required(ErrorMessage = "email is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.]+@([a-zA-Z0-9]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "email is not valid")]
        public string Host_HR_Director_Email { get; set; }
        public string Host_Line_Manager_Name { get; set; }

        [Required(ErrorMessage = "email is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.]+@([a-zA-Z0-9]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "email is not valid")]
        public string Host_Line_Manager_Email { get; set; }
        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Birthdate is required")]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "primary citizenship is required")]
        public string primaryCitizenship { get; set; }

        [Required(ErrorMessage = "secondary citizenship is required")]
        public string secondaryCitizenship { get; set; }

        [Required(ErrorMessage = "DAS Id is required")]
        public string DasId { get; set; }

        [Required(ErrorMessage = "email is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.]+@([a-zA-Z0-9]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "email is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = " GCM level in home country is required")]
        public string GCM_Id_Home_Country { get; set; }

        [Required(ErrorMessage = " GCM level in host country is required")]
        public string GCM_Id_Host_Country { get; set; }


        [Required(ErrorMessage = " family status in home country is required")]
        public string Family_Status_Home_Country { get; set; }

        [Required(ErrorMessage = " family status in host country is required")]
        public string Family_Host_Country { get; set; }

        [Required(ErrorMessage = "spouse location is required")]
        public string Spouse_location { get; set; }
        public string ChildrenName { get; set; }

        [Required(ErrorMessage = "Birthdate is required")]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

        public string primarycitizenship { get; set; }
        public string Dependent_for_tax_purpose_in_home_country { get; set; }


        public IEnumerable<SelectListItem> GCMItem { get; set; }
        public IEnumerable<SelectListItem> hostCountryList { get; set; }
        public IEnumerable<SelectListItem> hostCityList { get; set; }

    }
}