using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCDemo.Models;

namespace MVCDemo.DAL
{
    public class MVCDemoDbContext:DbContext
    {
        public MVCDemoDbContext():base("MVCDemoCS")
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}