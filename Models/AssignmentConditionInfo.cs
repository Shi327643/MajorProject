using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TravelBookingProject.Models
{
    [Table("AssignmentConditionInfo")]
    public class AssignmentConditionInfo
    {
        [Key]
        public int ConditionId { get; set; }
        [ForeignKey("Employee")]
        public string EmpId { get; set; }
        public DateTime Expected_Start_Date { get; set; }
        public DateTime Expected_End_Date { get; set; }
        public string Reason_Mobility_Request { get; set; }
        public string Employee_Replacing_International_Employee { get; set; }
       // public bool Employee_Replacing_International_Employee { get; set; }
        public string Employee_Reporting_To { get; set; }
        public string Performance_review_done_by { get; set; }
        public string Employee_Work_Full_Time_in_HostCountry { get; set; }
        //public bool Employee_Work_Full_Time_in_HostCountry { get; set; }
        public string Employee_Work_not_Full_Time_then_Estimated_Work_Schedule { get; set; }
        public string Employee_relationship_host_country { get; set; }
        public string Why_local_employee_not_consider_for_this_position { get; set; }
        public Employee Employee { get; set; }

    }
}