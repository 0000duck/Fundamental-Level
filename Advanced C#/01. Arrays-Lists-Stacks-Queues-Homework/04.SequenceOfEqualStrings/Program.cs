using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SequenceOfEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            int i;
            for (i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    Console.Write("{0} ", array[i]);
                }
                else
                {
                    Console.WriteLine("{0}", array[i]);
                }
            }
            Console.WriteLine("{0}", array[i]);
        }
    }
}
