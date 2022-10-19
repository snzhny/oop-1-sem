using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Laba9
{
    class Program
    {
        public static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
        } 
        public static void SecondTask()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var universalCollection = new ConcurrentDictionary<string, int>();
            var enotherCollection = new Dictionary<string, int>();

            universalCollection.TryAdd("A", 12);
            universalCollection.GetOrAdd("B", 12);
            universalCollection.TryAdd("C", 12);
            foreach (var keyValuePair in universalCollection) Console.WriteLine($"Key - {keyValuePair.Key} , Value - {keyValuePair.Value}");

            int tmp;
            universalCollection.TryRemove("A", out tmp);
            Console.WriteLine(tmp);

            foreach (var keyValuePair in universalCollection) enotherCollection.Add(keyValuePair.Key, keyValuePair.Value);
            foreach (var keyValuePair in enotherCollection) Console.WriteLine($"Key - {keyValuePair.Key} , Value - {keyValuePair.Value}");

            Console.WriteLine(enotherCollection.ContainsValue(12));
        }

        public static void FirstTask()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            var myCollection = new MyCollection<WebResourse>();
            var enotherCollection = myCollection;
            var web = new WebResourse();
            var array = new WebResourse[5];


            myCollection.Add(new WebResourse("KEK.by"));
            myCollection.Add(new WebResourse("TUT.by"));
            myCollection.Add(new WebResourse("read.by"));
            myCollection.Show();
            myCollection.Insert(1, web);
            Console.WriteLine(myCollection.Contains(web));
            Console.WriteLine(myCollection.IndexOf(web));
            myCollection.Show();
            myCollection.Remove(web);
            myCollection.RemoveAt(0);
            Console.WriteLine(myCollection[0]);


            myCollection.CopyTo(array, 2);
            foreach (var i in array) Console.Write($"{i} ");
            Console.WriteLine();

            myCollection.Show();

            myCollection.Clear();
            myCollection.Show();

            Console.WriteLine(myCollection.Equals(enotherCollection));
        }
        
        
        public static void ThirdTask()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            var myCollection = new ObservableCollection<WebResourse>();
            myCollection.CollectionChanged += SayChange;

            myCollection.Add(new WebResourse("KEK.by"));
            myCollection.Add(new WebResourse("TUT.by"));
            myCollection.Add(new WebResourse("read.by"));

            myCollection.RemoveAt(2);
        }
        public static void SayChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine("|Add comlete|");
            else if (e.Action == NotifyCollectionChangedAction.Remove) Console.WriteLine("|Remove complete|");
        }
    }
}