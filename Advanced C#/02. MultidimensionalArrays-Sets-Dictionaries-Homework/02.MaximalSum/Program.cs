using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];

            int[][] source = new int[N][];
            int[,] matrix = new int[N, M];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                source[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            matrix = To2D(source);
            int maxSum = int.MinValue;
            int tmpSum = 0;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < N - 2; row++)
            {
                for (int col = 0; col < M - 2; col++)
                {
                    tmpSum = CalcSum(row, col, matrix);

                    if (tmpSum > maxSum)
                    {
                        maxRow = row;
                        maxCol = col;
                        maxSum = tmpSum;
                    }
                }
            }

            Console.WriteLine("\n   Sum = {0}", maxSum);
            PrintMatrix(matrix, maxRow, maxCol);

        }

        private static void PrintMatrix(int[,] matrix, int maxRow, int maxCol)
        {
            for (int rows = maxRow; rows <= maxRow + 2; rows++)
            {
                for (int cols = maxCol; cols <= maxCol + 2; cols++)
                {
                    Console.Write("{0,4}", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int CalcSum(int startRow, int startCol, int[,] matrix)
        {
            int sum = 0;
            for (int row = startRow; row < startRow + 3; row++)
            {
                for (int col = startCol; col < startCol + 3; col++)
                {
                    sum = sum + matrix[row, col];
                }
            }

            return sum;
        }

        static T[,] To2D<T>(T[][] source)
        {
            int FirstDim = source.Length;
            int SecondDim = source.GroupBy(row => row.Length).Single().Key;

            var result = new T[FirstDim, SecondDim];
            for (int i = 0; i < FirstDim; ++i)
            {
                for (int j = 0; j < SecondDim; ++j)
                {
                    result[i, j] = source[i][j];
                }
            }
            return result;
        }
    }
}
