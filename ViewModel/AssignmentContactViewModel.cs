using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TravelBookingProject.Models;

namespace TravelBookingProject.ViewModel
{
    public class AssignmentContactViewModel
    {
        [Required(ErrorMessage ="Budget holder Name is Required")]
        public string BudgetHolderName { get; set; }
        [Required(ErrorMessage = "Budget holder EmailId is Required")]
        public string BudgetHolder_Email { get; set; }
        [Required(ErrorMessage = "Home HR Director Name is Required")]
        public string Home_HR_Director_Name { get; set; }
        [Required(ErrorMessage = "Home HR Director Email is Required")]
        public string Home_HR_Director_Email { get; set; }
        [Required(ErrorMessage = "Home Line Manager Name is Required")]
        public string Home_Line_Manager_Name { get; set; }
        [Required(ErrorMessage = "Home Line Manager EmailId is Required")]
        public string Home_Line_Manager_Email { get; set; }
        [Required(ErrorMessage = "Host HR Director Name is Required")]
        public string Host_HR_Director_Name { get; set; }
        [Required(ErrorMessage ="Host HR Director Email is Required")]
        public string Host_HR_Director_Email { get; set; }
        [Required(ErrorMessage = "Host Line Manager Name is Required")]
        public string Host_Line_Manager_Name { get; set; }
        [Required(ErrorMessage = "Host Line Manager EmailId is Required")]
        public string Host_Line_Manager_Email { get; set; }
    }
}