using System;

namespace laba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SecondTask();
            ThirdTask();
            FourthTask();
            fifthTask();
        }

        public static void SecondTask()
        {
            var bus1 = new Bus();
            var bus2 = new Bus("Snezhny", "Snezhny V.D.", "501-K", "1", "Tesla", 5, 100);
            
            Console.WriteLine(bus1.Equals(bus2) ? "Идентичны": "Не идентичны");
            Console.WriteLine($"Type of bus1 - {bus1.GetType()}");
            
            bus2.ShowInfo();
            
            Console.WriteLine("Ref and Out Parametres :");
            int busYear = bus2.ExpYear;
            Bus.IncreaseExpYear(ref busYear);
            bus2.ExpYear = busYear;
            Console.WriteLine(bus2.ExpYear);

            Bus.ChangeBrand(out string brand, "Changed Brand");
            bus2.BusBrand = brand;
            Console.WriteLine(bus2.BusBrand);
        }
        public static void ThirdTask()
        {
            var Buses = new Bus[4];
            Buses[0] = new Bus("Petrov.", "Petrov A.K.", "501-Fs", "one", "Mers", 20, 3);
            Buses[1] = new Bus("Ivanov", "Ivanov Q.L.", "523-S", "two", "Buggati", 10, 532);
            Buses[2] = new Bus("Cringe", "Cringe P.S.", "901-K", "third", "MAN", 52, 434);
            Buses[3] = new Bus("Anreyeva", "Anreyeva A.L", "115-K", "fourth", "Snezhny", 10,664);

            foreach (var bus in Buses)
                if (bus.RouteNumber == "one")
                    Console.WriteLine(bus.BusNumber);

            foreach (var bus in Buses)
                if (bus.ShowBusExpulatationYear() > 12)
                    Console.WriteLine($"{bus.BusNumber} : {bus.ExpYear} years"); 
            
        }

        public static void FourthTask()
        {
            var mainDriverInfo = new { Name = "Slavik", surname = "Snezhny", patronymic = "Dmitrievich" };
            Console.WriteLine($"Driver Full Name: {mainDriverInfo.Name} {mainDriverInfo.surname} {mainDriverInfo.patronymic}");
        }
        public static void fifthTask()
        {
            partialClassBus PBus = new partialClassBus();
            PBus.showDriverInfo();
        }   
    }
}