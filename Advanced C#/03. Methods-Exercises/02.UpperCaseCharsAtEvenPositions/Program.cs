using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.UpperCaseCharsAtEvenPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(UpperCaseCharsAtEvenPositions(input));
        }

        static string UpperCaseCharsAtEvenPositions(string str)
        {
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if(i % 2 == 0)
                {
                    arr[i] = char.ToUpper(arr[i]);
                }
            }
            return new string(arr);
        }
    }
}
