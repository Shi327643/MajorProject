using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TravelBookingProject.Models
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public class LoginContext : DbContext
    {
        public LoginContext() : base("name=connstr")
        {

        }

        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<GCM> GCMs { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<Travelers> Travelers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<EmployeePersonalInfo> EmployeePersonalInfos { get; set; }
        public DbSet<EmployeeFamilyInfo> EmployeeFamilyInfos { get; set; }  
        public DbSet<EmployeeChildrenInfo> EmployeeChildInfos { get; set; }    
        public DbSet<AssignmentContactInfo> AssignmentContactInfos { get; set; }
        public DbSet<ProjectDetailInfo> ProjectDetailInfos { get; set; }
        public DbSet<AssignmentDetailInfo> AssignmentDetailInfos { get; set; }
        public DbSet<AssignmentConditionInfo> AssignmentConditionInfos { get; set; }    

    }
}