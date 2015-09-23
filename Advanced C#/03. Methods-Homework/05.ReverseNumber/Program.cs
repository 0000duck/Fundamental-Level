using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double reversed = GetReversedNumber(123.45);
            Console.WriteLine(reversed);
        }
        
        static double GetReversedNumber(double number)
        {
            return double.Parse(new string(number.ToString().Reverse().ToArray()));
        }
    }
}
