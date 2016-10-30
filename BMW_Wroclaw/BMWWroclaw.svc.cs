using BMW_Wroclaw.DAO;
using Common;
using NHibernate;
using System.Collections.Generic;

namespace BMW_Wroclaw
{
    public class BMWWroclaw : IBMWWroclaw
    {
        public IList<Car> GetCars()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                ICriteria cars = session.CreateCriteria(typeof(Car));
                var carList = cars.List<Car>();
                return carList;
            }
        }
    }
}
