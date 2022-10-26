using System;
using laba_10;
using laba_2;

namespace Program;

public class Program{
    
    public static void Main(string[] args)
    {
        // FirstTask();
        // ThirdTask();
        FourthTask();
    }

    public static void FirstTask()
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
        int monthLength = 4;
        
        Console.WriteLine($"Month lengths: {monthLength}");
        foreach (var month in from m in months where m.Length == monthLength select m) { Console.WriteLine(month); }
        
        Console.WriteLine("Summer and Winter month:");
        foreach (var month in from m in months
                 where Array.IndexOf(months, m) < 2
                       || Array.IndexOf(months, m) > 4
                       && Array.IndexOf(months, m) < 8
                       || Array.IndexOf(months, m) == 11 select m
                ) Console.WriteLine(month);
        
        Console.WriteLine("Months in alphabet order:");
        foreach (var month in from m in months orderby m select m) Console.WriteLine(month); 
        
        Console.WriteLine("Month that have 'u' and month length < 4:");
        foreach (var month in from m in months where m.Contains('u') && m.Length >=4 select m) Console.WriteLine(month);
    }

    public static void ThirdTask()
    {
        var busList = new List<Bus>();
        
        busList.Add(new Bus("Petrov", "Petrov I.I.", "501-K", "1", "Mers", 20, 20));
        busList.Add(new Bus("Ivanov A.A", "Ivanov", "503-K", "1", "MAN", 10, 432));
        busList.Add(new Bus("Zvorikyn D.D.", "Zvorikyn", "501-K", "2", "Mers", 5, 2));
        busList.Add(new Bus("Stalmahova N.A.", "Stalmahova", "506-K", "2", "Audi", 12, 32));
        busList.Add(new Bus("Snezniy V.D.", "Snezniy", "505-K", "3", "BMW", 212, 32));
        busList.Add(new Bus("Shiman D.V.", "Shiman", "506-K", "3", "Audi", 132,523));
        busList.Add(new Bus("Artemov A.A", "Artemov", "507-K", "4", "Mers", 112, 532));
        busList.Add(new Bus("Stalmahova N.A.", "Stalmahova", "508-K", "4", "Mers", 15,52));

        Console.WriteLine("List of buses for 2 route: ");
        foreach (var item in busList.Where(b=> b.RouteNumber == "2")) { Console.WriteLine(item.BusNumber); }
        
        Console.WriteLine("Buses where expilatation time > 16");
        foreach (var item in busList.Where(b=> b.ExpYear >= 16)) { Console.WriteLine(item.BusNumber); }
        
        Console.WriteLine("who has the lowest mileage:");
        Console.WriteLine(busList.Single(i => i.Mileage==busList.Min(b=>b.Mileage)).BusNumber);
        
        Console.WriteLine("Two buses with the max car mileage:");
        Console.WriteLine(busList.OrderByDescending(i=>i.Mileage).ToList()[0].BusNumber);
        Console.WriteLine(busList.OrderByDescending(i=>i.Mileage).ToList()[1].BusNumber);
        
        Console.WriteLine("A list of buses ordered by bus number:");
        foreach (var bus in busList.OrderBy(b=>b.BusNumber)) { Console.WriteLine(bus.BusNumber); }
        
        Console.WriteLine("5 operators:");
        int a = busList.OrderBy(x => x.ExpYear).Where(x=>x.Mileage>100).Skip(1).Take(2).Sum(x=>x.ExpYear);
        Console.WriteLine(a);

    }

    public static void FourthTask()
    {
        var busList = new List<Bus>();
        busList.Add(new Bus("Petrov", "Petrov I.I.", "501-K", "1", "Mers", 20, 1000));
        busList.Add(new Bus("Ivanov", "Ivanov A.A", "503-K", "2", "Mers", 10, 1421));

        var personList = new List<Person>();
        personList.Add(new Person("Ivanov","501-K"));
        personList.Add(new Person("Petrov","503-K"));

        var result = from p in personList
            join bus in busList on p.BusNumber equals bus.BusNumber
            select new { Name = p.Name, BusNumber = p.BusNumber, Mileage = bus.Mileage };

        foreach (var item in result) { Console.WriteLine(item.ToString()); }
    }
}