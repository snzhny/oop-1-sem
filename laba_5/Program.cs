using System;

namespace laba_5
{
    class Program
    {
        static void Main(string[] args)
        {

            // FirstTask();
            // ThirdTask();
            // FourthTask();
            // SeventhTask();
            EightTast();
        }

        public static void FirstTask()
        {
            var cricket_ball = new CricketBall();
            cricket_ball.HelloWorld();
        }

        public static void ThirdTask()
        {
            var firstItem = new Ball("A", 2000);
            var secondItem = new Bench("B", 1000);
            var thirdItem = new Mats("C", 3000);
            var fourthItem = new Mats("D", 500);
            var fifthItem = new Bars("E", 500);

            var gym = new Gym(10000, 10, firstItem, secondItem, thirdItem);
            gym.PrintInfo();
            gym.Delete(firstItem);
            gym.PrintInfo();
            gym.Add(fourthItem);
            gym.Add(fifthItem);
            gym.Add(firstItem);
            gym.PrintInfo();
        }

        public static void FourthTask()
        {
            var firstItem = new Ball("A", 2000);
            var secondItem = new Ball("B", 1000);
            var thirdItem = new Ball("C", 3000);

            var gym = new Gym(10000, 5, firstItem, secondItem, thirdItem);
            var controller = new Controller();

            foreach (var item in controller.FindByCost(gym, 1000, 2500)) Console.WriteLine($"{item.ToString()} : {item.cost}");
        }

        public static void SeventhTask()
        {
            var gym = new Gym(10000, 5);
            var controller = new Controller();
            controller.ReadStringFromTxt(gym);
            gym.PrintInfo();

        }

        //FIX
        public static void EightTast()
        {
            var gym = new Gym(10000, 5);
            var controller = new Controller();
            controller.ReadStringFromJSON(gym);
            gym.PrintInfo();
            
        }
        

    }
}