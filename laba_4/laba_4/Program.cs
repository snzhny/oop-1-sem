using System;

namespace laba_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // FirstTask();
            // FourthTask();
            // FifthTask();
            SeventhTask();
        }

        public static void FirstTask()
        {
            var BasketBall = new BasketBall("Basket Ball");

            Console.WriteLine(BasketBall.inventory_name);
        }

        public static void FourthTask()
        {
            IMeow meow = new Ball();
            var test = new Ball();
            
            test.meow();
        }

        public static void FifthTask()
        {
            BasketBall basket_Ball = new BasketBall();
            
            Console.WriteLine($"Is basket_Ball a Ball  - {basket_Ball is Ball}");
            Ball ball = basket_Ball;//Upcast is correct

            TennisBall FirstTennisBall = new TennisBall();
            TennisBall SecondTennisBall = new TennisBall();
            BasketBall FirstBasketball = new BasketBall();

            if (FirstBasketball is TennisBall) { Console.WriteLine("The first is correct"); }
            
            else { Console.WriteLine("The first is not correct"); }

            if ((SecondTennisBall == ball as TennisBall) != null) { Console.WriteLine("The second one is correct"); }

        }

        public static void SeventhTask()
        {
            
            var bench = new Bench();
            var mats = new Mats();
            var bars = new Bars();
            var ball = new BasketBall();

            var inventoryItems = new Inventory[4];
            var printer = new Printer();

            inventoryItems[0] = bench;
            inventoryItems[1] = mats;
            inventoryItems[2] = bars;
            inventoryItems[3] = ball;

            foreach (var item in inventoryItems)
            {
                printer.IAmPrinting(item);
            }


        }
        }
    }
