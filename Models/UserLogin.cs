using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelBookingProject.Models
{
    [Table("UserLogin")]
    public class UserLogin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        [Column("UserName", TypeName = "Varchar")]
        [MaxLength(20)]
        public string UserName { get; set; }

       
        [Column("Password", TypeName = "Varchar")]
        [MaxLength(20)]
        public string Password { get; set; }
        [ForeignKey("Employee")]
        [Column("EmpId", TypeName ="varchar")]
        [MaxLength(20)]
        public string EmpId { get; set; }



        public Employee Employee { get; set; }
    }
}