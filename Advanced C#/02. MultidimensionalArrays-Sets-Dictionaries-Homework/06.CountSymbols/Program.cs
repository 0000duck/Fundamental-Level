using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            foreach (char item in input)
            {
                if (!symbols.ContainsKey(item))
                {
                    symbols.Add(item, 1);
                }
                else
                {
                    symbols[item]++;
                }
            }

            char[] charKeys = symbols.Keys.ToArray();

            foreach (char item in charKeys)
            {
                Console.WriteLine("{0}: {1} time/s", item, symbols[item]);
            }
        }
    }
}
