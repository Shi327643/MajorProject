using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TravelBookingProject.Models;

namespace TravelBookingProject.ViewModel
{
    public class ProjectDetailViewModel
    {
        
        public string EmpId { get; set; }
        [Required(ErrorMessage ="Role in Host Country is Required")]
        public string Role_in_Host_Country { get; set; }
        [Required(ErrorMessage = "Description of Role is Required")]
        public string Role_description_Host_Country { get; set; }
        [Required(ErrorMessage = "Annual base salary is Required")]
        public decimal Annual_base_Salary { get; set; }
        [Required(ErrorMessage = "Worldline Entity Name Bearing Costs is Required")]
        public string Worldline_Entity_name_bearing_costs { get; set; }
        [Required(ErrorMessage = "Worldline Costs Centre Bearing Cost is Required")]
        public string worldline_costs_centre_bearing_costs { get; set; }
        [Required(ErrorMessage = "Client Name for Whome Employee Working is Required")]
        public string Client_name_for_whome_Employee_Working { get; set; }
        [Required(ErrorMessage = "Project Name is Required")]
        public string Project_name_on_which_Employee_Working { get; set; }
        [Required(ErrorMessage = "Nature of Activity is Required")]
        public string Nature_of_Activity { get; set; }
        [Required(ErrorMessage = "Worldline Recruitment or WFM request ID is Required")]
        public string Worldline_recruitment { get; set; }
    }
}