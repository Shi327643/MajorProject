using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TravelBookingProject.Models
{
    [Table("EmployeeFamilyInfo")]
    public class EmployeeFamilyInfo
    {
        [Key]
        public int FamilyId { get; set; }
        [ForeignKey("Employee")]
        public string EmpId { get; set; }
        public string Family_Status_Home_Country { get; set; }
        public string Family_Host_Country { get; set; }
        public string Spouse_Location { get; set; }
        public Employee Employee { get; set; }
    }
}