namespace laba_6;

public class Logger
{
    public static void LogginInFile(Exception e)
    {
        using (StreamWriter writer = new StreamWriter(@"D:\unik\oop\laba_6\laba_6\log.log", true))
        {
            writer.WriteLine($"DateTime: {DateTime.Now}");
            writer.WriteLine($"Errors info: {e.Message} - {e.StackTrace}");
        }
    }
    
    public static void LogginInConsole(Exception e)
    {
        Console.WriteLine($"DateTime: {DateTime.Now}");
        Console.WriteLine($"Errors info: {e.Message} - {e.StackTrace}");
    }
}