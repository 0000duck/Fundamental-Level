using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SortArrayOfNumbersSelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            SelectionSortArray(arr);

            Console.WriteLine(string.Join(" ", arr));
        }

        static void SelectionSortArray(int[] array)
        {
            int currentMinimum;
            for (int i = 0; i < array.Length - 1; i++)
            {
                currentMinimum = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[currentMinimum])
                    {
                        currentMinimum = j;
                    }
                }
                if (currentMinimum != i)
                {
                    array[i] ^= array[currentMinimum];
                    array[currentMinimum] ^= array[i];
                    array[i] ^= array[currentMinimum];
                }
            }
        }
    }
}
