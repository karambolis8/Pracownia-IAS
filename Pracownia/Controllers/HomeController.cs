using AutoMapper;
using Pracownia.BmwWawa;
using Pracownia.BmwWroclaw;
using Pracownia.DataObjects;
using Pracownia.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Pracownia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IList<BmwCar> carsWawa;
            IList<BmwCar> carsWroclaw;

            using (var client = new BMWWawaClient())
            {
                carsWawa = Mapper.Map<IList<CarWawa>, IList<BmwCar>>(client.GetCars());
            }

            using (var client = new BMWWroclawClient())
            {
                carsWroclaw = Mapper.Map<IList<Car>, IList<BmwCar>>(client.GetCars());
            }

            var allCars = new List<BmwCar>();
            allCars.AddRange(carsWawa);
            allCars.AddRange(carsWroclaw);

            var model = new HomeVM
            {
                Cars = allCars.OrderBy(c => c.Price).ToList()
            };

            return View(model);
        }
    }
}