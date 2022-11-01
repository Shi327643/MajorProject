using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TravelBookingProject.Models
{
    [Table("EmployeeChildrenInfo")]
    public class EmployeeChildrenInfo
    {
        [Key]
        public int ChildId { get; set; }
        public string ChildrenName { get; set; }
        public DateTime ChildDateOfBirth { get; set; }
        public string PrimaryCitizenship { get; set; }
        public string Dependent_for_tax_purpose_in_home_country { get; set; }
        [ForeignKey("Employee")]
        public string EmpId { get; set; }
        public Employee Employee { get; set; }
    }
}