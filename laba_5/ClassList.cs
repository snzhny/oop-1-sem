using System;

namespace laba_5
{
    public abstract class Inventory
    {
        public string inventory_name { get; set; }
        public int cost { get; set; }
        enum meow{meow, nyan}
        public Inventory() { cost = 100; }
        struct Hello
        {
            public string name;

            public void HelloWorld()
            {
                Console.WriteLine("Hello World");
            }
        }
    }
    public class Bench : Inventory
    {
        public Bench() { inventory_name = "Bench"; }
        public Bench(string inventory_Name, int Cost) { inventory_name = inventory_Name; cost=Cost;}
        
    }
    public class Bars : Inventory
    {
        public Bars() { inventory_name = "Bars"; }
        public Bars(string inventory_Name, int Cost) { inventory_name = inventory_Name; cost=Cost;}
    }
    public class Ball : Inventory, IMeow
    {
        public Ball() { inventory_name = "Ball"; }
        public Ball(string inventory_Name, int Cost) { inventory_name = inventory_Name; cost=Cost;}

        public void meow() => Console.WriteLine("MEOW BLYAT!");
    }
    public class Mats : Inventory
    {
        public Mats() { inventory_name = "Mats"; }
        public Mats(string inventory_Name, int Cost) { inventory_name = inventory_Name; cost=Cost;}
    }

    interface IMeow { public void meow(); }

    interface IItForSport
    {
        public void sport(string sport_name);
    }
    
    public class BasketBall : Ball
    {    
        public BasketBall() { inventory_name = "BasketBall";}   
        public BasketBall(string inventory_Name, int Cost) { inventory_name = inventory_Name; cost=Cost;}
        public void sport(string sport_name) => Console.WriteLine($"Its for {sport_name}");
        public override string ToString()
        {
            return $"It's a {GetType()} name - {this.inventory_name}";
        }   
    }

    public sealed class TennisBall : Ball, IItForSport
    {
        public void sport(string sport_name) => Console.WriteLine($"Its for {sport_name}");
        public override string ToString()
        {
            return $"There is a {GetType()} name - {this.inventory_name}";
            
        }

        public override bool Equals(object? obj)
        {
            return inventory_name == obj;
        }
    }

}