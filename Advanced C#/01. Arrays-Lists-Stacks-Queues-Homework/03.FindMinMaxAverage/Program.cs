using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FindMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            
            List<int> roundNumbers = new List<int>();
            List<double> floatNumbers = new List<double>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 1 == 0)
                {
                    roundNumbers.Add((int)numbers[i]);
                }
                else
                {
                    floatNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(", ", floatNumbers), floatNumbers.Min(), floatNumbers.Max(), floatNumbers.Sum(), floatNumbers.Average());
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(", ", roundNumbers), roundNumbers.Min(), roundNumbers.Max(), roundNumbers.Sum(), (double)roundNumbers.Average());
        }
    }
}
