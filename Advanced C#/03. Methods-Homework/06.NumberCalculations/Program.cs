using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumberCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double[][] jaggedArrayD = new double[][]
        {
            new double[] { 1.5, 3.755, 4.1, 5.43, 1.06, 0.3, 5.6 },
            new double[] { 1.1, 2.54, 3.44, 4.0, 5.0, 6.005, 6.6 },
            new double[] { 1.1, 1.1, 1.1 },
        };

            decimal[][] jaggedArrayM = new decimal[][]
            {
            new decimal[] { 7.5m, 3.755m, 4.1m },
            new decimal[] { 1.1m, 2.54m, 3.44m, 4.0m, 5.0m, 6.005m },
            new decimal[] { 7.7m, 7.7m, 7.7m, 8.8m, 8.8m, 8.8m, 8.8m },
            };

            Console.WriteLine("\r\nDouble:\r\n");

            foreach (var arr in jaggedArrayD)
            {
                string strArr = string.Join(", ", arr);
                Console.WriteLine("{{ {0} }}:", strArr);
                Console.WriteLine("Minimum - {0}", GetMin(arr));
                Console.WriteLine("Maximum - {0}", GetMax(arr));
                Console.WriteLine("Average - {0}", GetAverage(arr));
                Console.WriteLine("Sum - {0}", GetSum(arr));
                Console.WriteLine("Product - {0}", GetProduct(arr));
                Console.WriteLine(new string('-', 20));
            }

            Console.WriteLine("\r\nDecimal:\r\n");

            foreach (var arr in jaggedArrayM)
            {
                string strArr = string.Join(", ", arr);
                Console.WriteLine("{{ {0} }}:", strArr);
                Console.WriteLine("Minimum - {0}", GetMin(arr));
                Console.WriteLine("Maximum - {0}", GetMax(arr));
                Console.WriteLine("Average - {0}", GetAverage(arr));
                Console.WriteLine("Sum - {0}", GetSum(arr));
                Console.WriteLine("Product - {0}", GetProduct(arr));
                Console.WriteLine(new string('-', 20));
            }
        }

        static double GetMin(double[] array)
        {
            double min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        static decimal GetMin(decimal[] array)
        {
            decimal min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        static double GetMax(double[] array)
        {
            double max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static decimal GetMax(decimal[] array)
        {
            decimal max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static double GetSum(double[] array)
        {
            double sum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static decimal GetSum(decimal[] array)
        {
            decimal sum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static double GetAverage(double[] array)
        {
            return GetSum(array) / array.Length;
        }

        static decimal GetAverage(decimal[] array)
        {
            return GetSum(array) / array.Length;
        }

        static double GetProduct(double[] array)
        {
            double product = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }

        static decimal GetProduct(decimal[] array)
        {
            decimal product = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
    }
}
