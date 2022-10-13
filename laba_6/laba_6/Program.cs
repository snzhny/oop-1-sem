using System;
using System.Diagnostics;

namespace laba_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // FirstTask();
            // FourthTask();
            FifthTask();
            // SixthTask();
        }

        public static void FirstTask()
        {
            int minusNumb = -1;
            int secNumb = 1000;
            int result, zero=0;
            
            result = secNumb / minusNumb;
            
            if (result < 0) { throw new NegativeDivision(); }
            if (zero == 0) { throw new ZeroResult("Zero Result!", result); }
            
            try { new Mats("Mats", 200); }
            catch (InventoryException ex) { Console.WriteLine(ex.Message); }
            
            try { new Mats("Mats", 200000); }
            catch (CostException ex) { Console.WriteLine(ex.Message); }
            
            
            try { Console.WriteLine(secNumb / 0); }
            catch (DivideByZeroException ex) { Console.WriteLine(ex.Message); }

            try
            {
                new Mats("Masts", 200);
                result = secNumb / 0;
            }
            catch { Console.WriteLine("Error! Check lines in 'try' block"); }
        }

        public static void FourthTask()
        {
            try { new Ball("Mats", 100); }
            catch (InventoryException e) { Console.WriteLine(e); }
            finally{Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("TRY-CATCH-FINALLY");}
        }

        public static void FifthTask()  
        {
            int a = 100;
            try
            {
                // new Mats("Meow", 200);
                Console.WriteLine(a/0);
            }
            catch (InventoryException ex) { Console.WriteLine(ex.Message); }
            catch (DivideByZeroException ex) { Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.HelpLink);
                Logger.LogginInFile(ex);
                Logger.LogginInConsole(ex);
                throw new Exception("KEK");
            }
        }

        public static void SixthTask()
        {
            int[] aa = new []{1,3,4};
            int[] nullArray = null;
            
            Debug.Assert(aa !=null, "Values array cannot be null");
            //Проверяет условие. Если условие имеет значение false, выдается сообщение и отображается окно сообщения со стеком вызовов.
            Debug.Assert(nullArray !=null, "Values array cannot be null");
            
            // -------- checking debug capabilities --------
            Debug.Indent(); //start
            Debug.WriteLine("Entering Main");
            Console.WriteLine("Hello World.");
            // Debugger.Break(); // создает точку остановки
            Debug.WriteLine("Exiting Main");    
            Debug.Unindent(); //end
            // ---------------------------------------------
            
        }

    }
}