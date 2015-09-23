using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> lst = new List<string>(Console.ReadLine().Split());
            //List<string> lst2 = new List<string>(Console.ReadLine().Split());
            List<int> lst = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> lst2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < lst2.Count; i++)
            {
                if (!lst.Contains(lst2[i]))
                {
                    lst.Add(lst2[i]);
                }
                else
                {
                    continue;
                }
            }

            lst.Sort();
            Console.WriteLine(string.Join(", ", lst));
        }
    }
}
