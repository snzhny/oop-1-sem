using System;

namespace laba_8{

class Program
{
    
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        // FirstTask();
        SecondTasK();
    }

    public static void FirstTask()
    {
        var software1 = new Software("Sofware #1", "1.0", true);
        var software2 = new Software("Sofware #2", "1.0", false);
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("-----------------------------------------------------------------------------");
        software1.SoftwareInfo();
        software2.SoftwareInfo();
        
        software1.VersionController("1.1");
        software1.KillProcess();
        Console.WriteLine();
        software2.VersionController("2.0");
        software2.StartProcess();
        
        software1.SoftwareInfo();
        software2.SoftwareInfo();
        Console.WriteLine("-----------------------------------------------------------------------------");
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("-----------------------------------------------------------------------------");
        
        User.Upgrade(software1,"1.2");
        User.StartWorkWithSoftware(software1);
        software1.SoftwareInfo();

        Console.WriteLine("-----------------------------------------------------------------------------");

    }
    public static void SecondTasK()
    {
        Func<string, string> T;
        
        
        string str = "   fsdsdfs .,;   ";
        int index = 3;
        string value = "$$$";
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine((str));
        T = StringProcessing.BidirectionalSpaceStrip;
        Console.WriteLine(T(str));
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine((str));
        T = StringProcessing.RemovePunctuation;
        Console.WriteLine(T(str));
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine((str));
        T = StringProcessing.Toupper;
        Console.WriteLine(T(str));
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine((str));
        T = StringProcessing.Toupper;
        Console.WriteLine(T(str));
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine((str));
        T = StringProcessing.AddingSymbolsToStart;
        Console.WriteLine(T(str));
    }
}

}