using EFP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFP
{
    public class VehicleContext: DbContext
    {
        public VehicleContext(): base("Vehicleconnection")
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}