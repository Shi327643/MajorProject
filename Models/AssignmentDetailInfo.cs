using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBookingProject.Models
{
    [Table("AssignmentDetailInfo")]
    public class AssignmentDetailInfo
    {
        [Key]
        public int DetailId { get; set; }
        [ForeignKey("Employee")]
        public string EmpId { get; set; }
        public string HomeCountryId { get; set; }
        public int HomeCityId { get; set; }
        public string HostCountryId { get; set; }
        public int HostCityId { get; set; }
        public string FromGBU { get; set; }
        public string ToGBU { get; set; }
        public string FromLegalEntity { get; set; }
        public string ToLegalEntity { get; set; }
        public string FromDivision { get; set; }
        public string ToDivision { get; set; }
        public Employee Employee { get; set; }
    }
}