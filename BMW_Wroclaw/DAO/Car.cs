using System.Runtime.Serialization;

namespace BMW_Wroclaw.DAO
{
    [DataContract]
    public class Car
    {
        public virtual int Id { get; set; }

        [DataMember]
        public virtual string Series { get; set; }

        [DataMember]
        public virtual string Version { get; set; }

        [DataMember]
        public virtual string Body { get; set; }

        [DataMember]
        public virtual char FuelType { get; set; }

        [DataMember]
        public virtual int EngineCapacity { get; set; }

        [DataMember]
        public virtual int Power { get; set; }

        [DataMember]
        public virtual char GearboxType { get; set; }

        [DataMember]
        public virtual int Price { get; set; }

        [DataMember]
        public virtual string Colour { get; set; }
    }
}