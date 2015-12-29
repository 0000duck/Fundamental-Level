using System;

namespace ConsoleApplication1
{
    class MatrixMultiplyMain
    {
        static void Main(string[] args)
        {
            double[,] firstMatrix = { { 1, 3 }, { 5, 7 } };
            double[,] secondMatrix = { { 4, 2 }, { 1, 5 } };
            double[,] resultMatrix = MultiplyMatrices(firstMatrix, secondMatrix);

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        static double[,] MultiplyMatrices(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new Exception("Error!");
            }

            int firstColsLength = firstMatrix.GetLength(1);
            int firstRowsLength = firstMatrix.GetLength(0);
            int secondColsLength = secondMatrix.GetLength(1);

            double[,] resultMatrix = new double[firstRowsLength, secondColsLength];

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < firstColsLength; k++)
                    {
                        resultMatrix[i, j] += firstMatrix[i, k]*secondMatrix[k, j];
                    }
                }
            }

            return resultMatrix;
        }
    }
}