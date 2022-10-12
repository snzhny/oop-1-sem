
using Newtonsoft.Json;
namespace laba_5;

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

    public void ReadStringFromJSON(Gym gym)
    {
        var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
        using var stream = new StreamReader(@"D:\unik\oop\laba_5\laba_5\data.json");
        string JsonData = stream.ReadToEnd();
        var deserializedList = JsonConvert.DeserializeObject<List<Inventory>>(JsonData);
        foreach (var item in deserializedList) gym.Add(item);
        // FIX
    
    }

    
}