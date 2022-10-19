namespace laba_8;

public class StringProcessing
{
    public static string RemovePunctuation(string str)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        return str.Replace(".,;", "");
    }

    public static string BidirectionalSpaceStrip(string str)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        return str.Trim();
    }
    public static string AddingSymbolsToStart(string str)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        return str.Insert(1, "$$$");
    }
    public static string Toupper(string str)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        return str.ToUpper();
    }
    public static string ToLower(string str)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        return str.ToLower();
    }
}