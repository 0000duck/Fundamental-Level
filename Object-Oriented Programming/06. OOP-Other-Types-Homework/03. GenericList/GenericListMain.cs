using System;

namespace _03.GenericList
{
    class GenericListMain
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            list.Version();
            Console.WriteLine(list.Count);
            list.Add(1);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Contains(6));
            Console.WriteLine(list.FindIndex(17));
            list.Insert(21341, 12);
            Console.WriteLine(list);
            list.Remove(0);
            Console.WriteLine(list);
            list[2] = 23;
            Console.WriteLine(list);
            list.Clear();
            Console.WriteLine(list);
        }
    }
}
