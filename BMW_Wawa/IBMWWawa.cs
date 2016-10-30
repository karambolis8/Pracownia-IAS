using BMW_Wawa.DO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BMW_Wawa
{
    [ServiceContract]
    public interface IBMWWawa
    {
        [OperationContract]
        IList<CarWawa> GetCars();
    }
}
