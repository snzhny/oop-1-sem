using System;

namespace laba_3
{
    /*
     * Класс - однонаправленный список List. Дополнительно перегрузить следующие операции: ! – инверсия элементов;
        + - объединить два списка; = = - проверка на равенство; < -
        добавление одного списка к другому.
        Методы расширения:
        1) Усечение строки до заданной длины
        2) Сумма элементов списка
     */
    public class List<T> : IControl<T>
    {
        public class Node
        {
            public T Data { get; set; }
            public Node Pointer { get; set; }
        }
        public Node Head { get; private set; }
        public Node Tail { get; private set; }

        private int _nodeCount;
        
        public class Production
        {
            private int _prod_Id;
            public string OrgName { get; set; }

            public Production (int id, string orgname)
            {
                _prod_Id = id;
                OrgName = orgname;
            }
        }

        public class Developer
        {
            private int _developer_Id;
            public string developerName { get; set; }
            public string developerDepartment { get; set; }

            public Developer(int id, string devname, string devdep)
            {
                _developer_Id = id;
                developerName = devname;
                developerDepartment = devdep;
            }
        }
        
        public List(T data)
        {
            Head = Tail = new Node(); 
            Head.Data = data;
            Tail.Data = data;
            _nodeCount = 1;
        }
        public List()
        {
            Head = Tail = new Node();
            _nodeCount = 0;
        }

        public void Add(T data)
        {
            var newNode = new Node
            {
                Data = data
            };

            if (_nodeCount == 0)
            {
                Tail = Head = newNode;
            }
            else
            {
                Tail.Pointer = newNode;
                Tail = newNode;
            }

            _nodeCount++;
        }

        public void Delete(T data)
        {
            if (_nodeCount == 0)
                throw new InvalidOperationException();
            
            Node current = Head;
            Node previous = null;

            while (current!=null)
            {
                if (Equals(current.Data, data))
                {
                    _nodeCount--;
                    if (previous == null)
                    {
                        Head = Head.Pointer;
                        if (Head == null)
                        {
                            Tail = null;
                        }
                        return;
                    }

                    previous.Pointer = current.Pointer;

                    if (current.Pointer == null)
                        Tail = previous;
                    
                    return;
                }

                previous = current;
                current = current.Pointer;
            }
        }

        public void Show()
        {
            if (_nodeCount == 0)
            {
                Console.WriteLine("The list is empty");
                return;
            }

            if (_nodeCount == 1)
            {
                Console.WriteLine($"(HEAD){Head.Data}(TAIL)-->NULL");
                return;
            }

            Node current = Head;

            Console.Write($"{current.Data}(HEAD)-->");

            current = current.Pointer;

            while (current.Pointer!=null)
            {
                Console.Write($"{current.Data}-->");
                current = current.Pointer;
            }
            Console.WriteLine($"{current.Data}(TAIL)-->NULL");


        }
        //--------------------------------------------------------------------------------------------
        public void WriteToFile <T>()
        {
            using (StreamWriter sw = new StreamWriter(@"D:\unik\oop\laba_7\laba_7\data.txt"))
            {
                var temp = Head;
                while (temp.Pointer != null)
                {
                    sw.Write($"{temp.Data} - ");
                    temp = temp.Pointer;
                }
                sw.WriteLine(temp.Data);
            }
        }

        public T[] ReadFromFile<T>()
        {
            using (StreamReader sw = new StreamReader(@"D:\unik\oop\laba_7\laba_7\data.txt"))
            {
                string[] items = sw.ReadToEnd().Split(" - ");
                
                T[] outputItems = new T[items.Length];


                int counter = 0;
                foreach (string item in items)
                {
                    outputItems[counter] = (T)Convert.ChangeType(item, typeof(T));
                    counter++;
                }

                return outputItems;
            }
        }
        //--------------------------------------------------------------------------------------------
        public void Clear()
        {
            Head = Tail = new Node();
            _nodeCount = 0;
        }
        
        
        // overload

        public static List<T> operator <(List<T> firstList, List<T> secondList) { return (firstList + secondList); }
        public static List<T> operator >(List<T> firstList, List<T> secondList) { return (secondList + firstList); }
        
        public static List<T> operator +(List<T> firstList, List<T> secondList)
        {
            List<T> newList = new List<T>();

            if (firstList._nodeCount>0){
                var current = firstList.Head;
                while (current != null)
                {
                    newList.Add(current.Data);
                    current = current.Pointer;
                }
            }
            if (secondList._nodeCount>0){
                var current = secondList.Head;
                while (current != null)
                {
                    newList.Add(current.Data);
                    current = current.Pointer;
                }
            }
            
            return newList;
        }

        public static bool operator ==(List<T> firstList, List<T> secondList)
        {
            if (firstList._nodeCount != secondList._nodeCount)
                return false;

            var currentFirst = firstList.Head;
            var currentSecond = secondList.Head;
            while (currentFirst != null)
            {
                if (!Equals(currentFirst.Data, currentSecond.Data))
                    return false;
                currentFirst = currentFirst.Pointer;
                currentSecond = currentSecond.Pointer;
            }

            return true;
        }

        public static bool operator !=(List<T> firstList, List<T> secondList)
        {
            return (firstList != secondList);
        }
        
        

    }
}