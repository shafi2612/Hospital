using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HospitalProjectInMVC.Models
{
    public class ContextDb : DbContext
    {
        public ContextDb() : base("name=ContextDb")
        {
        }

        public DbSet<Doctor> doctors { get; set; }

    }
}