using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SequenceInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int count = 1;
            int maxSecq = 1;
            string maxValue = "";

            string[,] matrix = new string[N, M];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if(matrix[i,j] == matrix[i, j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    if(count > maxSecq)
                    {
                        maxSecq = count;
                        maxValue = matrix[i, j];
                    }
                }
                count = 1;
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    if (matrix[i, j] == matrix[i + 1, j])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    if (count > maxSecq)
                    {
                        maxSecq = count;
                        maxValue = matrix[i, j];
                    }
                }
                count = 1;
            }

            for (int i = 0, j = 0; i < matrix.GetLength(0) - 1 && j < matrix.GetLength(1) - 1; i++, j++)
            {
                if (matrix[i, j] == matrix[i + 1, j + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxSecq)
                {
                    maxSecq = count;
                    maxValue = matrix[i, j];
                }
            }
            count = 1;

            for (int i = 0, j = 0; i < matrix.GetLength(0) - 1 && j > 0; i++, j--)
            {
                if (matrix[i, j] == matrix[i + 1, j + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxSecq)
                {
                    maxSecq = count;
                    maxValue = matrix[i, j];
                }
            }

            for (int i = 0; i < maxSecq; i++)
            {
                if (i < maxSecq - 1)
                {
                    Console.Write("{0}, ", maxValue);
                }
                else
                {
                    Console.Write("{0}", maxValue);
                }

            }
            Console.WriteLine();
        }
    }
}
