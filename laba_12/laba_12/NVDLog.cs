namespace laba_12;

public static class NVDLog
{
    public static void WriteInTXT(string message)
    {
        using (var stream = new StreamWriter(@"D:\unik\oop\laba_12\laba_12\NVDlogfile.txt", true))
        {
            stream.WriteLine($"{DateTime.Now.ToString()}\n{message}\n------------------------------");
        }
    }
}