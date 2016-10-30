using System.Runtime.Serialization;

namespace BMW_Wawa.DO
{
    [DataContract]
    public class CarWawa
    {
        public virtual int Id { get; set; }

        [DataMember]
        public virtual string Seria { get; set; }

        [DataMember]
        public virtual string Wersja { get; set; }

        [DataMember]
        public virtual string Nadwozie { get; set; }

        [DataMember]
        public virtual char Silnik { get; set; }

        [DataMember]
        public virtual int Pojemnosc { get; set; }

        [DataMember]
        public virtual int Moc { get; set; }

        [DataMember]
        public virtual char Skrzynia { get; set; }

        [DataMember]
        public virtual int Cena { get; set; }

        [DataMember]
        public virtual string Kolor { get; set; }
    }
}