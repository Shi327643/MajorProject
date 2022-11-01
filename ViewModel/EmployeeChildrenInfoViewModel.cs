using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBookingProject.ViewModel
{
    public class EmployeeChildrenInfoViewModel
    {
        [Required(ErrorMessage ="Children Name is required")]
        public string ChildrenName { get; set; }
        [Required(ErrorMessage ="Date of Birth is required")]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-mmm-dd}")]
        public DateTime ChildDateOfBirth { get; set; }
        [Required(ErrorMessage ="Primary Citizenship is required")]
        public string PrimaryCitizenship { get; set; }
        [Required(ErrorMessage ="Dependent for tax purpose is required")]
        public string Dependent_for_tax_purpose_in_home_country { get; set; }
        public string  EmpId { get; set; }
    }
}