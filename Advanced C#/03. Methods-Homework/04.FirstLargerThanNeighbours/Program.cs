using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FirstLargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
        }

        static int GetIndexOfFirstElementLargerThanNeighbours(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(i != 0 && i != array.Length)
                {
                    if(array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
