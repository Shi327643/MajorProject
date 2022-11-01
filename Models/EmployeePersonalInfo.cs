using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBookingProject.Models
{
    [Table("EmployeePersonalInfo")]
    public class EmployeePersonalInfo
    {
        [Key]
        public int ResponseId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [ForeignKey("Employee")]
        public string EmpId { get; set; }
        public Employee Employee { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PrimaryCitizenship { get; set; }
        public string SecondaryCitizenship { get; set; }
        public string DasId { get; set; }
        public string Email { get; set; }
        [ForeignKey("GCM")]
        public int GCM_Id_Home_Country { get; set; }
       
        
        public int GCM_Id_Host_Country { get; set; }

        public GCM GCM { get; set; }


    }
}