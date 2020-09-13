using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalProjectInMVC.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Perment { get; set; }
       public string OpenTime { get; set; }
       public string CloseTime { get; set; }
    }
}