using BMW_Wawa.DO;
using Common;
using NHibernate;
using System.Collections.Generic;

namespace BMW_Wawa
{
    public class BmwWawa : IBMWWawa
    {
        public IList<CarWawa> GetCars()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                ICriteria cars = session.CreateCriteria(typeof(CarWawa));
                var carList = cars.List<CarWawa>();
                return carList;
            }
        }
    }
}
