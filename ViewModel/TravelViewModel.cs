using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBookingProject.Models;
namespace TravelBookingProject.ViewModel
{
    public class TravelViewModel { 
    
        public Employee Employee { get; set; }
        public string EmpName { get; set; }
        public string EmpId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserLogin UserLogin { get; set; }
        public string Status { get; set; }
        public int GCMId { get; set; }
        public string GCM_Level { get; set; }
        public int TravelId { get; set; }
        public string Travel_Type { get; set; } 

        public Travelers Travelers { get; set; }
        public GCM GCM { get; set; }
        public Travel Travel { get; set; }
        

        public IList<UserLogin> userList { get; set; }
        public IList<Employee> EmpList { get; set; }
        public IList<Country> countryList { get; set; }
        public IList<City> cityList { get; set; }
        public IList<GCM> GCMList { get; set; }
        public IList<Travel> travelList { get; set; }
        public IList<Travelers> travlersList { get; set; }
        public IEnumerable<SelectListItem> GCMItem { get; set; }
        public IEnumerable<SelectListItem> TravelItem { get; set; }
        public TravelViewModel()
        {
            userList = new List<UserLogin>();
            EmpList = new List<Employee>();
            countryList = new List<Country>();
            cityList = new List<City>();
            GCMList = new List<GCM>();
            
            travelList = new List<Travel>();
            travlersList = new List<Travelers>();
        }

    }
}