using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List<T>.
            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6, 7
            //};

            //List<int> numbers2 = new List<int>()
            //{
            //    8,9,10,11,12,13
            //};
            //numbers.Add(1);

            //numbers.AddRange(numbers2);
            //Console.WriteLine(numbers.Contains(15));
            //Console.WriteLine(numbers.IndexOf(1));
            ////numbers.Insert(2,5);
            ////numbers.Remove(5);
            ////numbers.RemoveAt(0);
            ////numbers.RemoveRange(1, 10);
            //numbers.Reverse(1,3);


            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);

            //}
            //List<Student> students = new List<Student>()
            //{
            //    new Student(){Name = "Rahim",Age=24,GroupNo="p231"},
            //    new Student(){Name = "Samir",Age=17,GroupNo="k526"},
            //    new Student(){Name = "Bahruz",Age=14,GroupNo="c485"},

            //};
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.Name);
            //}




            #endregion

            #region Dictionary<TKey,TValue>.
            //Dictionary<string, string[]> kvp = new Dictionary<string, string[]>()
            //{
            //    { "AZE", new string[]{"Baki","Lacin","Susa","Sumqayit" } },
            //    {"TR",new string[]{ "Istanbul","Ankara","Antep"} }
            //};
            //kvp.Add("USA", new string[] { "Los Angleas ", "Briston", "Hollywood" });
            //foreach (var item in kvp["USA"])
            //{
            //    Console.WriteLine(item);
            //}

            //string[] nameViliage = new string[] { "Boston", "New York" };
            //if (kvp.TryGetValue("A",out nameViliage))
            //{
            //    foreach (var item in nameViliage)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}
            //if (kvp.ContainsKey("TR"))
            //{
            //    foreach (var item in kvp["TR"])
            //    {
            //        Console.WriteLine(item);
            //    }
            //    kvp.Remove("TR");


            //}
            //foreach (var item in kvp)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item.Value)
            //    {
            //        Console.WriteLine(item2);
            //    }

            //}

            #endregion

            #region Sorted<TKey,TValue>
            SortedList<int, string> kvp = new SortedList<int, string>()
            {
                {2,"alma" },
                {4,"armud" },
                {3,"heyva" },
                {1,"xurma" }

            };
            kvp.Remove(1);
            foreach (var item in kvp)
            {
                Console.WriteLine($"{item.Key} -- {item.Value}");
            }
            
            kvp.RemoveAt(10);
            foreach (var item in kvp)
            {
                Console.WriteLine($"{item.Key} -- {item.Value}");
            }


            #endregion
        }
    }
}
