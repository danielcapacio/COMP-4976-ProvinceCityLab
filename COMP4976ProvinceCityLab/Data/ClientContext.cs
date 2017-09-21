using COMP4976ProvinceCityLab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace COMP4976ProvinceCityLab.Data
{
    public class ClientContext : DbContext
    {
        public ClientContext() 
            : base("DefaultConnection")
        {

        }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}