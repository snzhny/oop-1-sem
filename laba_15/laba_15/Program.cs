using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace laba_15;

class Program
{
    public static void Main(string[] args)
    {
        // FirstTask();
        // SecondTask();
        // ThirdFourhTask();
        // FifthTask();
        // Sixthtask();
        SeventhTask();
        // EigthTask();
    }

    public static void FirstTask()
    {
        Stopwatch stopwatch = new Stopwatch();
        
        
        Task task1 = null;
        task1 = new Task(() =>
        {
            Console.Write("N = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"TASK1 INFO:\n{task1.Id} {task1.Status}");
            Console.ForegroundColor = ConsoleColor.Gray;
            var primeNumbers = SieveEratosthenes(n);
            Console.WriteLine("Простые числа до заданного {0}:", n);
            Console.WriteLine(string.Join(", ", primeNumbers));
        });
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"TASK1 INFO:\n{task1.Id} {task1.Status}");
        Console.ForegroundColor = ConsoleColor.Gray;
        
        stopwatch.Start();
        task1.Start();
        task1.Wait();
        stopwatch.Stop();
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"TASK1 INFO:\n{task1.Id} {task1.Status}");
        
        TimeSpan ts = stopwatch.Elapsed;
        
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime: " + elapsedTime);
    }
    static List<uint> SieveEratosthenes(uint n)
    {
        var numbers = new List<uint>();
        for (var i = 2u; i < n; i++) { numbers.Add(i); }

        for (var i = 0; i < numbers.Count; i++)
        {
            for (var j = 2u; j < n; j++)
            {
                numbers.Remove(numbers[i] * j);
            }
        }
        return numbers;
    }

    public static void SecondTask()
    {
        Stopwatch stopwatch = new Stopwatch();
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        CancellationToken token = cancellationTokenSource.Token;
        
        
        Task task1 = null;
        task1 = new Task(() =>
        {
            Console.Write("N = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"TASK1 INFO:\n{task1.Id} {task1.Status}");
            Console.ForegroundColor = ConsoleColor.Gray;
            var primeNumbers = SieveEratosthenes(n);
            Console.WriteLine("Простые числа до заданного {0}:", n);
            Console.WriteLine(string.Join(", ", primeNumbers));
        }, token);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"TASK1 INFO:\n{task1.Id} {task1.Status}");
        Console.ForegroundColor = ConsoleColor.Gray;
        
        stopwatch.Start();
        task1.Start();
        // Thread.Sleep(1000);
        
        cancellationTokenSource.Cancel();
       
        
        task1.Wait();
        stopwatch.Stop();
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"TASK1 INFO:\n{task1.Id} {task1.Status}");
        
        TimeSpan ts = stopwatch.Elapsed;
        
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime: " + elapsedTime);
    }

    public static void ThirdFourhTask()
    {
        Task task1 = new Task(()=>Console.WriteLine("1 TASK"));
        Task task2 = task1.ContinueWith(ReturnTask);
        Task task3 = task2.ContinueWith(ReturnTask);

        task1.Start();

        task3.Wait();
        // task3.GetAwaiter().GetResult();
        
        Console.WriteLine("End of 3 task");
    }

    static void ReturnTask(Task t)
    {
        Console.WriteLine($"TASK ID: {t.Id}");
    }

    public static void FifthTask()
    {
        var array1 = new int[10000000];
        var array2 = new int[10000000];
        var array3 = new int[10000000];

        var stopwatch = new Stopwatch();

        stopwatch.Start();
        Parallel.For(0, 10000000, CreatingArrayElements);
        stopwatch.Stop();
        Console.WriteLine($"Parallel For {stopwatch.ElapsedMilliseconds} ms");

        stopwatch.Restart();
        for (var i = 0; i < 10000000; i++)
        {
            array1[i] = 1;
            array2[i] = 1;
            array3[i] = 1;
        }
        stopwatch.Stop();
        Console.WriteLine($"Native For {stopwatch.ElapsedMilliseconds} ms");


        int sum = 0;
        stopwatch.Restart();
        Parallel.ForEach(array1, SumOfElements);
        stopwatch.Stop();
        Console.WriteLine($"Parallel ForEach {stopwatch.ElapsedMilliseconds} ms");
            
        sum = 0;
        stopwatch.Restart();
        foreach (int item in array1) sum += item;
        stopwatch.Stop();
        Console.WriteLine($"Native ForEach {stopwatch.ElapsedMilliseconds} ms");
            
        void CreatingArrayElements(int x)
        {
            array1[x] = 1;
            array2[x] = 1;
            array3[x] = 1;
        }

        void SumOfElements(int item)
        {
            sum += item;
        }
    }

    public static void Sixthtask()
    {
        var array1 = new int[10000000];
        var array2 = new int[10000000];
        var array3 = new int[10000000];
                
            
        Parallel.Invoke
        (
              
            () =>
            {
                for (var i = 0; i < array1.Length; i++)
                {
                    array1[i] = i;
                }
            },
            () =>
            {
                for (var i = 0; i < array2.Length; i++)
                {
                    array2[i] = i;
                }
            },
            () =>
            {
                for (var i = 0; i < array3.Length; i++)
                {
                    array3[i] = i;
                }
            }
        );
    }

    public static void SeventhTask()
    {
        BlockingCollection<string> bc = new BlockingCollection<string>(5);

            Task[] sellers = new Task[10]
            {
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(700);
                        bc.Add("Стол");
                    }
                }),
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(700);
                        bc.Add("Шкаф");
                    }
                }),
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(700);
                        bc.Add("Зеркало");
                    }
                }),
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(700);
                        bc.Add("Бра");
                    }
                }),
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(700);
                        bc.Add("Подоконник");
                    }
                }),
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(700);
                        bc.Add("Микроволновка");
                    }
                }),
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(700);
                        bc.Add("Кровать");
                    }
                }),
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(700);
                        bc.Add("Дверь");
                    }
                }),
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(700);
                        bc.Add("Вазон");
                    }
                }),
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(700);
                        bc.Add("Стул");
                    }
                })
            };

            Task[] consumers = new Task[5]
            {
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(300);
                        bc.Take();
                    }
                }),
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(500);
                        bc.Take();
                    }
                }),
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(500);
                        bc.Take();
                    }
                }),
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(400);
                        bc.Take();
                    }
                }),
                new Task(() => {
                    while (true)
                    {
                        Thread.Sleep(250);
                        bc.Take();
                    }
                })
            };

            foreach (var i in sellers)
                if (i.Status != TaskStatus.Running)
                    i.Start();

            foreach (var i in consumers)
                if (i.Status != TaskStatus.Running)
                    i.Start();

            int count = 1;
            while (true)
            {
                if (bc.Count != count && bc.Count != 0)
                {
                    count = bc.Count;
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("---Склад---");

                    foreach (var i in bc)
                        Console.WriteLine(i);
                }
            }
        
    }
    
    public static void EigthTask()
    {
        void Factorial()
        {
            int result = 1;
            for (int i = 1; i <= 6; i++)
                result *= i;
            Thread.Sleep(1000);
            Console.WriteLine($"6! = {result}");
        }

        async void FactorialAsync()
        {
            Console.WriteLine("Factorial start");
            await Task.Run(() => Factorial());
            Console.WriteLine("Factorial ends");
        }

        FactorialAsync();
        Console.ReadKey();
    }
}