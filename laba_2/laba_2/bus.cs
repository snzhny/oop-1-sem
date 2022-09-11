using System;

namespace laba_2
{
    public partial class Bus
    {
        private const string FLAG = "FLAG{dnNqy6T%3|z3ZOZ}";        
        private readonly int busID;
        
        // class properties
        public string Driversurname { get; set; }
        public string DriverIni { get; set; }
        public string BusNumber { get; set; }
        public string RouteNumber { get; private set; }
        public string BusBrand { get; set; }
        public int ExpYear { get; set; }
        public int Mileage { get; set; }
        public static int BusCounter{ get; private set; }

        // constructors
        
        static Bus()
        {
            BusCounter = 0;
        }
        
        public Bus()
        {
            BusNumber = "Undefined";
            Driversurname = "Undefined";
            DriverIni = "Undefined";
            BusNumber = "Undefined";
            RouteNumber = "Undefined";
            BusBrand = "Undefined";
            ExpYear = 0;
            Mileage = 0;
            Bus.BusCounter++;
            busID = GetHashCode();

        }   

        public Bus(string driversurname, string driverIni, string busNumber, string routeNumber, string busBrand, int expYear, int mileage=0)
        {
            Driversurname = driversurname;
            DriverIni = driverIni;
            BusNumber = busNumber;
            RouteNumber = routeNumber;
            BusBrand = busBrand;
            ExpYear = expYear;
            Mileage = mileage;
            busID = GetHashCode();
        }

        private Bus(int usID)
        {
            BusNumber = "Undefined";
            Driversurname = "Undefined";
            DriverIni = "Undefined";
            BusNumber = "Undefined";
            RouteNumber = "Undefined";
            BusBrand = "Undefined";
            ExpYear = 0;
            Mileage = 0;
        }
        
        // methods

        public void ShowInfo() => Console.WriteLine($"{this.ToString()}; Hashed id number: {busID}");
        public static void IncreaseExpYear(ref int ExpYear) => ExpYear++;
        public static void ChangeBrand(out string brand, string BusBrand) => brand = BusBrand;
        public int ShowBusExpulatationYear() =>  ExpYear;
        public static Bus CreateBus(int Id) => new Bus(Id);
        
    }
}