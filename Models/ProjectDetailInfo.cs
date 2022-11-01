using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBookingProject.Models
{
    [Table("ProjectDetailInfo")]
    public class ProjectDetailInfo
    {
        [Key]
        public int ProjectId { get; set; }
        [ForeignKey("Employee")]
        public string EmpId { get; set; }
        public string Role_in_Host_Country { get; set; }
        public string Role_description_Host_Country { get; set; }
        public decimal Annual_base_Salary { get; set; }
        public string Worldline_Entity_name_bearing_costs { get; set; }
        public string worldline_costs_centre_bearing_costs { get; set; }
        public string Client_name_for_whome_Employee_Working { get; set; }
        public string Project_name_on_which_Employee_Working { get; set; }
        public string Nature_of_Activity { get; set; }
        public string Worldline_recruitment { get; set; }
        public Employee Employee { get; set; }
    }
}