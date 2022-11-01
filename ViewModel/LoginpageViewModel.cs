using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelBookingProject.ViewModel
{
    public class LoginpageViewModel
    {
        [Required(ErrorMessage = "Username is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
       
        public string DasId { get; set; }   
    }
}