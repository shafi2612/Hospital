using HospitalProjectInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalProjectInMVC.Controllers
{
    public class DoctorController : Controller
    {
        public ContextDb db = new ContextDb();


        public ActionResult Index(string search)
        {
            if (search != null)
            {
               return View(db.doctors.Where(x => x.Name.Contains(search)).ToList());
            }

           return View(db.doctors.ToList());
        }

            public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
            public ActionResult Create(Doctor d)
        {
            db.doctors.Add(d);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}