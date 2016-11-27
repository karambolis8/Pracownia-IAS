using AutoMapper;
using Pracownia.BmwWawa;
using Pracownia.BmwWroclaw;
using Pracownia.DataObjects;
using Pracownia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Pracownia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IList<BmwCar> carsWawa = null;
            IList<BmwCar> carsWroclaw = null;

            using (var client = new BMWWawaClient())
            {
                try
                {
                    carsWawa = Mapper.Map<IList<CarWawa>, IList<BmwCar>>(client.GetCars());
                }
                catch
                {
                    Console.WriteLine("BMWWawa service not available");
                }
            }

            using (var client = new BMWWroclawClient())
            {
                try
                {
                    carsWroclaw = Mapper.Map<IList<Car>, IList<BmwCar>>(client.GetCars());
                }
                catch
                {
                    Console.WriteLine("BMWWroclaw service not available");
                }
            }

            var allCars = new List<BmwCar>();

            if(carsWawa != null)
                allCars.AddRange(carsWawa);

            if(carsWroclaw != null)
                allCars.AddRange(carsWroclaw);

            var model = new HomeVM
            {
                Cars = allCars.OrderBy(c => c.Price).ToList()
            };

            return View(model);
        }
    }
}