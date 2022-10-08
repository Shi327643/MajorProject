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

    }
}