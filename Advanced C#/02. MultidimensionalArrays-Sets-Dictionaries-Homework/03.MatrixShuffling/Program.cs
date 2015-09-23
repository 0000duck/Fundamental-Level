using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            string[,] matrix = new string[N, M];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            while(true)
            {
                string input = Console.ReadLine();
                string[] command;

                if (input != "END")
                {
                    command = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (command[0] == "swap" && command.Length == 5)
                    {
                        int x1 = int.Parse(command[1]);
                        int x2 = int.Parse(command[2]);
                        int y1 = int.Parse(command[3]);
                        int y2 = int.Parse(command[4]);

                        if (ValidateCoordinates(x1, N, x2, y1, M, y2))
                        {
                            string temp = matrix[x1, x2];
                            matrix[x1, x2] = matrix[y1, y2];
                            matrix[y1, y2] = temp;
                            PrintMatrix(matrix);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private static bool ValidateCoordinates(int x1, int N, int x2, int y1, int M, int y2)
        {
            bool validX1 = x1 >= 0 && x1 < N;
            bool validX2 = x2 >= 0 && x2 < N;
            bool validY1 = y1 >= 0 && y1 < M;
            bool validY2 = y2 >= 0 && y1 < M;

            return validX1 && validX2 && validY1 && validY2;
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
