using System;

namespace laba_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // secondTask();
            // thirdTask();
            // fourthTask();
            fifthTask();
        }
        static void secondTask()
        {
            var list = new List<string>();
            try
            {
                list.Add("MEOW1");
                list.Add("MEOW2");
                list.Add("MEOW3");
                list.Show();
                list.Delete("MEOW2");
                list.Show();
                list.Delete("MEOW1");
                list.Show();
                list.Delete("MEOW3");
                list.Show();
                list.Delete("MEOW3");
            }
            catch (InvalidOperationException eX)
            {

                Console.WriteLine(eX.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }

        }

        public static void thirdTask()
        {
            var stList = new List<string>();
            var inList = new List<int>();
            var chList = new List<char>();
            
            Console.ForegroundColor = ConsoleColor.White;
            
            stList.Add("MEOW1");
            stList.Add("MEOW2");
            stList.Add("MEOW3");
            stList.Delete("MEOW2");
            stList.Show();

            Console.ForegroundColor = ConsoleColor.Blue;
            
            inList.Add(1);
            inList.Add(2);
            inList.Add(3);
            inList.Delete(2);
            inList.Show();
            
            Console.ForegroundColor = ConsoleColor.Red;
            
            chList.Add('A');
            chList.Add('B');
            chList.Add('C');
            chList.Delete('D');
            chList.Show();
        }

        public static void fourthTask()
        {
            var classList = new List<Meow>();
            var Meow = new Meow("MEOW", 40);
            var Meow1 = new Meow("MEOW1", 10);
            var Meow2 = new Meow("MEOW2", 30);
            
            classList.Add(Meow);
            classList.Add(Meow1);
            classList.Add(Meow2);
            
            classList.Show();
        }

        public static void fifthTask()
        {
            var strList = new List<string>();
            
            strList.Add("MEOW1");
            strList.Add("MEOW2");
            strList.Add("MEOW3");
            strList.Show();
            
            var itemsFromfile = new double[]{};
            strList.WriteToFile<string>();
            itemsFromfile= strList.ReadFromFile<double>();
            foreach (double s in itemsFromfile)
            {
                Console.WriteLine(s);   
            }
            

        }

    }
}