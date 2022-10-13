using System;

namespace laba_6
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

        public Bench(string inventory_Name, int Cost)
        {
            inventory_name = inventory_Name; cost=Cost;
            if (inventory_Name != "Bench")
            {
                throw new InventoryException("The name of the inventory corresponds to the named class!", "Bench");
            }

            if (Cost > 10000) { throw new CostException("Cost too much", "Bench", Cost); }
        }
        
    }
    public class Bars : Inventory
    {
        public Bars() { inventory_name = "Bars"; }

        public Bars(string inventory_Name, int Cost)
        {
            inventory_name = inventory_Name; cost=Cost;
            if (inventory_Name != "Bars")
            {
                throw new InventoryException("The name of the inventory corresponds to the named class!", "Bars");
            }

            if (Cost > 100000) { throw new CostException("Cost too much", "Bars", Cost); }
        }
    }
    public class Ball : Inventory, IMeow
    {
        public Ball() { inventory_name = "Ball"; }

        public Ball(string inventory_Name, int Cost)
        {
            inventory_name = inventory_Name; cost=Cost;
            if (inventory_Name != "Ball")
            {
                throw new InventoryException("The name of the inventory corresponds to the named class!", "Ball");
            }

            if (Cost > 1000) { throw new CostException("Cost too much", "Ball", Cost); }
        }

        public void meow() => Console.WriteLine("MEOW BLYAT!");
    }
    public class Mats : Inventory
    {
        public Mats() { inventory_name = "Mats"; }

        public Mats(string inventory_Name, int Cost)
        {
            inventory_name = inventory_Name; cost=Cost;
            if (inventory_Name != "Mats")
            {
                throw new InventoryException("The name of the inventory corresponds to the named class!", "Mats");
            }

            if (Cost > 10000) { throw new CostException("Cost too much", "Mats", Cost); }
            
        }
        
    }

    interface IMeow { public void meow(); }

    interface IItForSport
    {
        public void sport(string sport_name);
    }
    
    public class BasketBall : Ball
    {    
        public BasketBall() { inventory_name = "BasketBall";}

        public BasketBall(string inventory_Name, int Cost)
        {
            inventory_name = inventory_Name; cost=Cost;
            if (inventory_Name != "BasketBall")
            {
                throw new InventoryException("The name of the inventory corresponds to the named class!", "BasketBall");
            }

            if (Cost > 1000) { throw new CostException("Cost too much", "BasketBall", Cost); }
        }
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