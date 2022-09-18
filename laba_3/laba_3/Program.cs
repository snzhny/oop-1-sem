using System;

namespace laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstTask();
            //secondTask();
            //thirdTask();
            //fourthTask();
            //fifthTask();
        }
        static void FirstTask()
        {
            var myList = new List();

            myList.Show();

            myList.Add("A");
            myList.Add("B");
            myList.Add("C");
            myList.Show();

            myList.Remove("B");
            myList.Show();

            myList.Clear();
            myList.Show();

            var firstList = new List();
            firstList.Add("A");
            firstList.Add("B");
            firstList.Add("C");
            var secondList = new List();
            secondList.Add("D");
            secondList.Add("E");
            secondList.Add("F");

            Console.WriteLine($"First list and second list are equal ? - {firstList == myList}");

            Console.Write($"First list + second list: ");
            (firstList + secondList).Show();
            Console.Write($"First list inversed : ");
            (!firstList).Show();    
            (firstList < secondList).Show();
            (firstList > secondList).Show();
        }

        static void secondTask()
        {
            var prodList = new List.Production(0, "Snezhny CORP");
            Console.WriteLine($"Organization: {prodList.OrgName}");
        }
        static void thirdTask()
        {
            var devList = new List.Developer(0, "Snezhny", "Snezhny Department");
            Console.WriteLine($"Developer: {devList.developerName} from {devList.developerDepartment}");
        }
        static void fourthTask()
        {
            var myList = new List();
                myList.Add("small mess");
                myList.Add("middle mess");
                myList.Add("longest mess");
                Console.WriteLine(StatisticOperation.CountCapacity(myList));
                Console.WriteLine(StatisticOperation.FindTheLongestString(myList));

        }
        static void fifthTask(){
            var myList = new List();
            myList.Add("AAA");
            myList.Add("BBB");
            myList.Add("CCC");
            
            myList.ShortenString(1);
            myList.Show();

            Console.WriteLine(myList.ConcatAllElements());
        }
        
    }
}