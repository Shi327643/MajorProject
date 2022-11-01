using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelBookingProject.Models
{
    [Table("AssignmentContactInfo")]
    public class AssignmentContactInfo
    {
        [Key]
        public int ContactId { get; set; }
        public string BudgetHolderName { get; set; }
        [ForeignKey("Employee")]
        public string EmpId { get; set; }
        public string BudgetHolder_Email { get; set; }
        public string Home_HR_Director_Name { get; set; }
        public string Home_HR_Director_Email { get; set; }
        public string Home_Line_Manager_Name { get; set; }
        public string Home_Line_Manager_Email { get; set; }
        public string Host_HR_Director_Name { get; set; }
        public string Host_HR_Director_Email { get; set; }
        public string Host_Line_Manager_Name { get; set; }
        public string Host_Line_Manager_Email { get; set; }
        public Employee Employee { get; set; }
    }
}