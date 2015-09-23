using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[n, n];
            int[,] matrix2 = new int[n, n];

            int index1 = 1;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix1[col, row] = index1;
                    index1++;
                }
            }
            Console.WriteLine("  Pattern A: ");
            PrintMatrix(matrix1);
            Console.WriteLine();

            int leftColumn = 0;
            int upperRow = 0;
            int bottomRow = n - 1;
            int count = 1;
            int index2 = 1;
            do
            {
                for (int i = upperRow; i <= bottomRow; i++)
                {
                    matrix2[i, leftColumn] = index2;
                    count++;
                    index2++;
                }
                leftColumn++;

                for (int i = bottomRow; i >= upperRow; i--)
                {
                    matrix2[i, leftColumn] = index2;
                    count++;
                    index2++;
                }
                leftColumn++;

                for (int i = upperRow; i <= bottomRow; i++)
                {
                    matrix2[i, leftColumn] = index2;
                    count++;
                    index2++;
                }
                leftColumn++;

                for (int i = bottomRow; i >= upperRow; i--)
                {
                    matrix2[i, leftColumn] = index2;
                    count++;
                    index2++;
                }
                leftColumn++;
            } while (count <= n * n);
            Console.WriteLine("  Pattern B: ");
            PrintMatrix(matrix2);

        }

        static void PrintMatrix(int [,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
