using System;
using System.Diagnostics;
using System.Reflection;

namespace Laba_14;

public class Program
{
    public static void Main(string[] args)
    {
        // FirstTask();
        // SecondTask();
        // ThirdTask();
        // FourthTask();
        FifthTask();
    }

    public static void FirstTask()
    {
        var allProcess = Process.GetProcesses();
        foreach (var process in allProcess)
            try
            {
                Console.WriteLine(
                    $"ID: {process.Id}  Name: {process.ProcessName} Priority: {process.BasePriority} " +
                    $"VirtualMemorySize64: {process.VirtualMemorySize64}");
                Console.WriteLine(
                    $"Start time : {process.StartTime}  Total processor time: {process.TotalProcessorTime}\n");
            }
            catch { Console.WriteLine("DENIED CHEKING"); }}

    public static void SecondTask()
    {
        var domain = AppDomain.CurrentDomain;
        Console.WriteLine(
            $"Domain INFO: \n{domain.FriendlyName} {domain.SetupInformation} {domain.BaseDirectory}");
        Console.WriteLine("Sborki:");
        foreach (var ass in domain.GetAssemblies()) Console.WriteLine(ass.FullName);

        AppDomain newD = AppDomain.CreateDomain("New_Domain");
        newD.Load("laba_14");
        AppDomain.Unload(newD);
    }

    public static void ThirdTask()
    {
        var first = new Thread(ShowSimpleNumbers);
        first.Start();
        first.Name = "SimpleNumbersThread";
        first.Join();
        Console.WriteLine();
    }
    public static void ShowThreadInfo(object thread)
    {
        var currentThread = thread as Thread;
        Console.WriteLine($"Name: {currentThread.Name}");
        Console.WriteLine($"Id: {currentThread.ManagedThreadId}");
        Console.WriteLine($"Priority: {currentThread.Priority}");
        Console.WriteLine($"Status: {currentThread.ThreadState}");
    }
    public static void ShowSimpleNumbers()
    {
        var info = new Thread(ShowThreadInfo);
        info.Start(Thread.CurrentThread);
        info.Join();

        Console.WriteLine("INTER N!!!!!!!!!!!!!!!!!!!!!!!!");
        int n = int.Parse(Console.ReadLine());
        for (var i = 1; i <= n; i++)
        {
            var isSimple = true;
            for (var j = 2; j <= i / 2; j++)
                if (i % j == 0)
                {
                    isSimple = false;
                    break;
                }

            if (isSimple)
            {
                Console.Write($"{i} ");
                Thread.Sleep(100);
            }
        }
    }
    public static void FourthTask()
    {
        var even = new Thread(ShowEvenNumbers) {Priority = ThreadPriority.Highest};
        var odd = new Thread(ShowOddNumbers);
        even.Start();
        odd.Start();
        even.Join();
        odd.Join();

        Console.WriteLine();
        FirstlyEvenSecondlyOdd();
        Console.WriteLine();
        ShowOneByOne();
    }
    public static void ShowOneByOne()
    {
        var mutex = new Mutex();
        var even = new Thread(ShowEvenNumbers);
        var odd = new Thread(ShowOddNumbers);
        odd.Start();
        even.Start();
        even.Join();
        odd.Join();

        void ShowEvenNumbers()
        {
            for (var i = 0; i < 20; i++)
            {
                mutex.WaitOne();
                Console.ForegroundColor = ConsoleColor.Red;
                if (i % 2 == 0)
                    Console.Write(i + " ");
                mutex.ReleaseMutex();
            }
        }

        void ShowOddNumbers()
        {
            for (var i = 0; i < 20; i++)
            {
                mutex.WaitOne();
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Blue;
                if (i % 2 != 0)
                    Console.Write(i + " ");
                mutex.ReleaseMutex();
            }
        }
    }
    public static void FirstlyEvenSecondlyOdd()
    {
        var objectToLock = new object();
        var even = new Thread(ShowEvenNumbers);
        var odd = new Thread(ShowOddNumbers);
        even.Start();
        odd.Start();
        even.Join();
        odd.Join();

        void ShowEvenNumbers()
        {
            lock (objectToLock)
            {
                for (var i = 0; i < 20; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (i % 2 == 0)
                        Console.Write(i + " ");
                }
            }
        }

        void ShowOddNumbers()
        {
            for (var i = 0; i < 20; i++)
            {
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Blue;
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }
        }
    }
    public static void ShowEvenNumbers()
    {
        for (var i = 0; i < 20; i++)
        {
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Red;
            if (i % 2 == 0)
                Console.Write(i + " ");
        }
    }
    public static void ShowOddNumbers()
    {
        for (var i = 0; i < 20; i++)
        {
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Blue;
            if (i % 2 != 0)
                Console.Write(i + " ");
        }
    }

    public static void FifthTask()
    {
        Console.WriteLine();
        int counter = 1;
        TimerCallback timerCallback = new TimerCallback(WhatTimeIsIt);
        var timer = new Timer(timerCallback,null, 0, 1000);
        Thread.Sleep(5000);
        timer.Change(Timeout.Infinite, 2000);

        void WhatTimeIsIt(object obj)
        {
            Console.WriteLine(counter);
            counter++;
        }
    }

}