using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Lists_Stacks_Queues_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            sortArray(arr);

            Console.WriteLine(string.Join(", ", arr));
        }

        static void sortArray(int[] array)
        {
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[i - 1])
                    {
                        array[i - 1] ^= array[i];
                        array[i] ^= array[i - 1];
                        array[i - 1] ^= array[i];
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }
}
