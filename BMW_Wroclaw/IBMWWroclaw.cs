using BMW_Wroclaw.DAO;
using System.Collections.Generic;
using System.ServiceModel;

namespace BMW_Wroclaw
{
    [ServiceContract]
    public interface IBMWWroclaw
    {
        [OperationContract]
        IList<Car> GetCars();
    }
}
