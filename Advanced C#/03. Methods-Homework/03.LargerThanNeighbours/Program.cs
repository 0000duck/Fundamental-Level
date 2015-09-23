using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }
        }

        static bool IsLargerThanNeighbours(int[] array, int number)
        {
            if (number == 0)
            {
                return (array[number] > array[number + 1]) ? true : false;
            }
            else if (number == array.Length - 1)
            {
                return (array[number] > array[number - 1]) ? true : false;
            }
            else
            {
                return (array[number] > array[number + 1] && array[number] > array[number - 1]) ? true : false;
            }
        }
    }
}
