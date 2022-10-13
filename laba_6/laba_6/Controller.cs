using System.Text.Json;
using System.ComponentModel;

using System.Collections.Generic;

using JsonSerializer = System.Text.Json.JsonSerializer;

namespace laba_6;

public class Controller
{
    public List<Inventory> FindByCost(Gym gym, int minPrice, int maxPrice)
    {
        return gym.gymInventory.FindAll(i => i.cost < maxPrice && i.cost > minPrice);
    }

    public void ReadStringFromTxt(Gym gym)
    {
        var data = new StreamReader(@"D:\unik\oop\laba_5\laba_5\data.txt");
        while (data.ReadLine() is string line)
        {
            switch (line)
            {
                case "Bars":
                    gym.Add(new Bars());
                    break;
                case "Mats":
                    gym.Add(new Mats());
                    break;
                case "Bench":
                    gym.Add(new Bench());
                    break;
            }
        }
    }

    public void ReadStringFromJSON(Gym gym, string path)
    {
        using StreamReader sr = new(path);
        var str = sr.ReadToEnd();
        var obj = JsonSerializer.Deserialize<List<Gym>>(str);
        Console.WriteLine(obj);

    }
    
    
}