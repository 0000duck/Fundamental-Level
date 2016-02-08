namespace GameFifteen
{
    using System;

    public class RotatingWalkInMatrix
    {
        public static void RotateWalkInMatrix(int[,] matrix)
        {
            int number = matrix.GetLength(0);
            int value = 1;
            int row = 0;
            int col = 0;
            int dX = 1;
            int dY = 1;

            while (true)
            {
                // malko e kofti tova uslovie, no break-a raboti 100% : )
                matrix[row, col] = value;

                if (!CheckCell(matrix, row, col))
                {
                    // prekusvame ako sme se zadunili
                    break;
                }

                bool inBoundaries =
                    row + dX >= number ||
                    row + dX < 0 ||
                    col + dY >= number ||
                    col + dY < 0 ||
                    matrix[row + dX, col + dY] != 0;

                if (inBoundaries)
                {
                    while (row + dX >= number || row + dX < 0 || col + dY >= number || col + dY < 0 || matrix[row + dX, col + dY] != 0)
                    {
                        Change(ref dX, ref dY);
                    }
                }

                row += dX;
                col += dY;
                value++;
            }

            FindCell(matrix, out row, out col);

            if (row != 0 && col != 0)
            {
                // taka go napravih, zashtoto funkciqta ne mi davashe da ne si definiram out parametrite
                dX = 1;
                dY = 1;
                value++;

                while (true)
                {
                    // malko e kofti tova uslovie, no break-a raboti 100% : )
                    matrix[row, col] = value;

                    if (!CheckCell(matrix, row, col))
                    {
                        // prekusvame ako sme se zadunili
                        break;
                    }

                    bool inBoundaries =
                        row + dX >= number ||
                        row + dX < 0 ||
                        col + dY >= number ||
                        col + dY < 0 ||
                        matrix[row + dX, col + dY] != 0;

                    if (inBoundaries)
                    {
                        while (row + dX >= number || row + dX < 0 || col + dY >= number || col + dY < 0 || matrix[row + dX, col + dY] != 0)
                        {
                            Change(ref dX, ref dY);
                        }
                    }

                    row += dX;
                    col += dY;
                    value++;
                }
            }
        }

        private static void Change(ref int dX, ref int dY)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;

            for (int count = 0; count < 8; count++)
            {
                if (directionsX[count] == dX && directionsY[count] == dY)
                {
                    cd = count;
                    break;
                }
            }

            if (cd == 7)
            {
                dX = directionsX[0];
                dY = directionsY[0];
                return;
            }

            dX = directionsX[cd + 1];
            dY = directionsY[cd + 1];
        }

        private static bool CheckCell(int[,] array, int x, int y)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + directionsX[i] >= array.GetLength(0) || x + directionsX[i] < 0)
                {
                    directionsX[i] = 0;
                }

                if (y + directionsY[i] >= array.GetLength(0) || y + directionsY[i] < 0)
                {
                    directionsY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (array[x + directionsX[i], y + directionsY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static void FindCell(int[,] array, out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(0); col++)
                {
                    if (array[row, col] == 0)
                    {
                        x = row;
                        y = col;
                        return;
                    }
                }
            }
        }

        private static void PrintMatrix(int[,] array, int number)
        {
            for (int matrixRow = 0; matrixRow < number; matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < number; matrixCol++)
                {
                    Console.Write("{0,3}", array[matrixRow, matrixCol]);
                }

                Console.WriteLine();
            }
        }

        private static void Main()
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int number;

            while (!int.TryParse(input, out number) || number < 0 || number > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            int[,] matrix = new int[number, number];

            RotateWalkInMatrix(matrix);
            PrintMatrix(matrix, number);
        }
    }
}
