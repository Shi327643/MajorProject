using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBookingProject.Models;
namespace TravelBookingProject.ViewModel
{
    public class EmployeeAndFamilyViewModel
    {
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }
        
        public string EmpId { get; set; }
        [Required(ErrorMessage ="Date of birth is required")]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true/*, DataFormatString = "{0:yyyy-mmm-dd}"*/)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }
        [Required(ErrorMessage ="Primary Citizenship is Required")]
        public string PrimaryCitizenship { get; set; }
        [Required(ErrorMessage ="Secondary Citizenship is required")]
        public string SecondaryCitizenship { get; set; }
        [Required(ErrorMessage ="DasId is required")]
        public string DasId { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "GCM Level in home country is required")]
        public int GCM_Id_Home_Country { get; set; }
        [Required(ErrorMessage = "GCM level in host country is required")]
        public int GCM_Id_Host_Country { get; set; }
        [Required(ErrorMessage = "Family status in home country is required")]

        public string Family_Status_Home_Country { get; set; }
        [Required(ErrorMessage = "Family status in host country is required")]
        public string Family_Host_Country { get; set; }
        [Required(ErrorMessage = "Spouse location is required")]
        public string Spouse_Location { get; set; }

       

        public IEnumerable<SelectListItem> GCMItem { get; set; }

       
    }
}