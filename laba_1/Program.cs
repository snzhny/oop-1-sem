
	// Online C# Editor for free
	// Write, Edit and Run your C# code using C# Online Compiler

	using System;
	using System.Linq;
	using System.Text;

	public class HelloWorld
	{
	    public static void Main(string[] args)
	    {
		bool check = true;
		    Console.WriteLine(check ? "Checked" : "Not checked");  // output: Checked

		    Console.WriteLine(false ? "Checked" : "Not checked");  // output: Not checked
		    
		    byte value1 = 128;
		    Console.WriteLine(value1);

		    sbyte value2 = -101;
		    Console.WriteLine(value2);

		    char a = 'A';
		    Console.WriteLine(a);

		    double w = 78.65;
		    Console.WriteLine(w);

		    float f = 30.6f;
		    Console.WriteLine(f);

		    int r = 10;
		    Console.WriteLine(r);

		    uint e = 10;
		    Console.WriteLine(e);

		    long h = 20L;
		    Console.WriteLine(h);

		    ulong y = 30UL;
		    Console.WriteLine(y);

		    decimal b = 1005.8M;
		    Console.WriteLine(b);

		    short value3 = -11;
		    Console.WriteLine(value3);

		    ushort value4 = 1;
		    Console.WriteLine(value4);

		    int num = 2147483647;
		    long bigNum1 = num;
		    Console.WriteLine(bigNum1);
		    long bigNum2 = num;
		    Console.WriteLine(bigNum2);
		    long bigNum3 = num;
		    Console.WriteLine(bigNum3);
		    long bigNum4 = num;
		    Console.WriteLine(bigNum4);
		    long bigNum5 = num;
		    Console.WriteLine(bigNum5);

		    int n = Convert.ToInt32("23");
		    bool rw = true;
		    double d = Convert.ToDouble(rw);
		    Console.WriteLine($"n={n}  d={d}");

		    int up = 123;
		    object asd  = up;
		    Console.WriteLine(asd);

		    int first = 123;
		    object asb = first;
		    int second = (int)asb;
		    Console.WriteLine(second);

		    var hello = "Hell to World";
		    Console.WriteLine(hello);

		    int? val = null;
		    Console.WriteLine(val);



		    string string1 = "This is a string created by assignment.";
		    Console.WriteLine(string1);

		    string string2 = "Hello World";
		    string string3 = "Hello World";
		    Console.WriteLine(String.Equals(string2, string3));

		    string str1 = "This";
		    string str2 = "is";
		    string str3 = "me";
		    string str4 = str1 + " " + str2 + " " + str3;
		    Console.WriteLine(str4);

		    string strA = "hello";
		    string strB = String.Copy(strA);
		    Console.WriteLine(strA);
		    Console.WriteLine(strB);

		    String value = "This is a string.";
		    int startIndex = 5;
		    int length = 2;
		    String substring = value.Substring(startIndex, length);
		    Console.WriteLine(substring);


		    string s = "You win some. You lose some.";

		    string[] subs = s.Split(' ');

		    foreach (var sub in subs)
		    {
		        Console.WriteLine($"Substring: {sub}");
		    }


		    string text1 = "Хороший день";
		    string text2 = "замечательный ";

		    text1 = text1.Insert(8, text2);
		    Console.WriteLine(text1);

		    string text = "Хороший день";
		    // индекс последнего символа
		    int ind = text.Length - 1;
		    // вырезаем последний символ
		    text = text.Remove(ind);
		    Console.WriteLine(text);

		    string name = "Tom";
		    int age = 23;

		    Console.WriteLine($"Имя: {name}  Возраст: {age}");

		    bool TestForNullOrEmpty(string s)
		    {
		        bool result;
		        result = s == null || s == string.Empty;
		        return result;
		    }
		    string strok1 = "";
		    string strok2 = null;
		    Console.WriteLine(TestForNullOrEmpty(strok1));
		    Console.WriteLine(TestForNullOrEmpty(strok2));
		    
		    StringBuilder sb = new StringBuilder("ABCDEFG", 50);
		    char plus = '+';
		    
		    sb.Append(plus);
		    sb.Remove(2,1);
		    sb.Insert(0, plus);
		    
		    Console.WriteLine(sb.ToString()); 
		    
		               
		    int[,] myArr1 = new int[4, 5];
		    
		    Random ran = new Random();
		    
		    for (int i = 0; i < 4; i++)
		    {
		        for (int ja = 0; ja < 5; ja++)
		        {
		           myArr1[i, ja] = ran.Next(1, 15);
		           Console.Write("{0}\t", myArr1[i, ja]);
		        }
		        Console.WriteLine();
		    }

		    string[] daysOfWeek = { "Sunday", "Monday", "Tuersday",
	      "Wednesday", "Thirsday", "Friday", "Saturday" };

		// daysOfWeek[3] = "kek";
		
		int choosePos = Convert.ToInt32(Console.ReadLine());
		string chooseValue = Console.ReadLine();
		
		daysOfWeek[choosePos] = chooseValue;
		
	      for (int i = 0; i < daysOfWeek.Length; i++)
		Console.WriteLine("AS[{0}] = {1}", i, daysOfWeek[i]);
		
		Console.WriteLine(daysOfWeek.Length);
		
		int[][] myArr = new int[3][] { new int[2], new int[3], new int[4] };
		for(int i = 0; i < myArr.Length; i++)
		{
			for(int j = 0; j < myArr[i].Length; j++)
			{
				Console.Write($"myArr[{i}][{j}] = ");
				myArr[i][j] = int.Parse(Console.ReadLine());
			}
		}
		for(int i = 0; i < myArr.Length; i++)
		{
			Console.WriteLine(string.Join(" ",myArr[i]));
		}
		
		
		var neyavniy_massiv = new[] { 5, 10, 23, 16, 8 };
		var neyav_str = "";
		
		(int, string, char, string, ulong) kortezh = (1, "HELLO", '+', "ss", 21232131);
		Console.WriteLine(kortezh.Item1);
		Console.WriteLine(kortezh.Item3);
		Console.WriteLine(kortezh.Item4);

		Console.WriteLine(kortezh);

		var au_1 = kortezh.Item1;
		var au_2 = kortezh.Item2;
		
		Console.WriteLine($"{au_1};{au_2}");
		
		(var aaa, var bbb) = ("123", 456);
		Console.WriteLine($"{aaa} {bbb}"); //распаковка кортежа	

		var _kek = "kek";
		Console.WriteLine(_kek);
		
		
		var firstTuple = (9, 3);
		var secondTuple = (9, 3);
		
		if (firstTuple == secondTuple)
			Console.WriteLine("Первый кортеж равен второму");
		else
			Console.WriteLine("Первый кортеж не равен второму");

		static (int, int, int, char) LocalFunction (int[] arrVar, string strVar)  {
			int maxArrayElement = arrVar.Max();
			int minArrayElement = arrVar.Min();
			int arrayElementsSum = arrVar.Sum();
			char firstStringChar = strVar[0];
			return (maxArrayElement, minArrayElement, arrayElementsSum, firstStringChar);
		}
		int[] arrVar =new int[] {5, 3, 12, 42, -23}; 
		var strVar = "ABCD";
		Console.WriteLine(LocalFunction(arrVar,strVar));
		
		static void FunctionWithChecked()
		{
			checked
			{
				var intVar = int.MaxValue;
				intVar++;
				Console.WriteLine(intVar);
			}
		}

		static void FunctionWithUnchecked()
		{
			unchecked
			{
				var intVar = int.MaxValue;
				intVar++;
				Console.WriteLine(intVar);
			}
		}
		//FunctionWithChecked();
		//FunctionWithUnchecked();  
	    }
	    
	}
