using EFP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFP.Controllers
{
    public class EFCrudController : Controller
    {
      
        VehicleContext db = new VehicleContext();

        public ActionResult Index()
        {
            var Data = db.Vehicles.ToList();
            return View(Data);
        }
        public  ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Vehicle model)
        {
            db.Vehicles.Add(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}