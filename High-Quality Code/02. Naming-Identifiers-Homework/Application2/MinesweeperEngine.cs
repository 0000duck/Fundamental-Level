using System;
using System.Collections.Generic;

namespace MinesweeperGame
{
    public class MinesweeperEngine
    {
        private string command = string.Empty;
        private char[,] field = CreateGameField();
        private char[,] mines = PlantMines();
        private int counter = 0;
        private bool hasExploded = false;
        private readonly List<Ranking> champions = new List<Ranking>(6);
        private int row = 0;
        private int column = 0;
        private bool flag = true;
        private const int max = 35;
        private bool flag2 = false;

        public void Run()
        {
            do
            {
                if (this.flag)
                {
                    Console.WriteLine(
                        "Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki."
                        + " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    Dump(this.field);
                    this.flag = false;
                }

                Console.Write("Daj red i kolona : ");
                this.command = Console.ReadLine().Trim();
                if (this.command.Length >= 3)
                {
                    if (int.TryParse(this.command[0].ToString(), out row) && int.TryParse(this.command[2].ToString(), out this.column)
                        && this.row <= this.field.GetLength(0) && this.column <= this.field.GetLength(1))
                    {
                        this.command = "turn";
                    }
                }

                switch (this.command)
                {
                    case "top":
                        GetRanking(this.champions);
                        break;
                    case "restart":
                        this.field = CreateGameField();
                        this.mines = PlantMines();
                        Dump(this.field);
                        this.hasExploded = false;
                        this.flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (this.mines[this.row, this.column] != '*')
                        {
                            if (this.mines[this.row, this.column] == '-')
                            {
                                ChangeTurn(this.field, this.mines, this.row, this.column);
                                this.counter++;
                            }

                            if (max == this.counter)
                            {
                                this.flag2 = true;
                            }
                            else
                            {
                                Dump(this.field);
                            }
                        }
                        else
                        {
                            this.hasExploded = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (this.hasExploded)
                {
                    Dump(this.mines);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", this.counter);
                    string nickname = Console.ReadLine();
                    Ranking t = new Ranking(nickname, this.counter);
                    if (this.champions.Count < 5)
                    {
                        this.champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < this.champions.Count; i++)
                        {
                            if (this.champions[i].Points < t.Points)
                            {
                                this.champions.Insert(i, t);
                                this.champions.RemoveAt(this.champions.Count - 1);
                                break;
                            }
                        }
                    }

                    this.champions.Sort((Ranking r1, Ranking r2) => r2.Name.CompareTo(r1.Name));
                    this.champions.Sort((Ranking r1, Ranking r2) => r2.Points.CompareTo(r1.Points));
                    GetRanking(this.champions);

                    this.field = CreateGameField();
                    this.mines = PlantMines();
                    this.counter = 0;
                    this.hasExploded = false;
                    this.flag = true;
                }

                if (this.flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    Dump(this.mines);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string name = Console.ReadLine();
                    Ranking points = new Ranking(name, this.counter);
                    this.champions.Add(points);
                    GetRanking(champions);
                    this.field = CreateGameField();
                    this.mines = PlantMines();
                    this.counter = 0;
                    this.flag2 = false;
                    this.flag = true;
                }
            }
            while (this.command != "exit");
        }

        private static void GetRanking(List<Ranking> points)
        {
            Console.WriteLine("\nTo4KI:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void ChangeTurn(char[,] field, char[,] mines, int row, int column)
        {
            char numberOfMines = CountMines(mines, row, column);
            mines[row, column] = numberOfMines;
            field[row, column] = numberOfMines;
        }

        private static void Dump(char[,] board)
        {
            int boardRows = board.GetLength(0);
            int boardColumns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardColumns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlantMines()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int newMine = random.Next(50);
                if (!mines.Contains(newMine))
                {
                    mines.Add(newMine);
                }
            }

            foreach (int mine in mines)
            {
                int column = mine / boardColumns;
                int row = mine % boardColumns;
                if (row == 0 && mine != 0)
                {
                    column--;
                    row = boardColumns;
                }
                else
                {
                    row++;
                }

                board[column, row - 1] = '*';
            }

            return board;
        }

        private static void Calculate(char[,] field)
        {
            int column = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char count = CountMines(field, i, j);
                        field[i, j] = count;
                    }
                }
            }
        }

        private static char CountMines(char[,] field, int currentRow, int currentCol)
        {
            int mineCounter = 0;
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (field[currentRow - 1, currentCol] == '*')
                {
                    mineCounter++;
                }
            }

            if (currentRow + 1 < rows)
            {
                if (field[currentRow + 1, currentCol] == '*')
                {
                    mineCounter++;
                }
            }

            if (currentCol - 1 >= 0)
            {
                if (field[currentRow, currentCol - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if (currentCol + 1 < columns)
            {
                if (field[currentRow, currentCol + 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentCol - 1 >= 0))
            {
                if (field[currentRow - 1, currentCol - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentCol + 1 < columns))
            {
                if (field[currentRow - 1, currentCol + 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow + 1 < rows) && (currentCol - 1 >= 0))
            {
                if (field[currentRow + 1, currentCol - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow + 1 < rows) && (currentCol + 1 < columns))
            {
                if (field[currentRow + 1, currentCol + 1] == '*')
                {
                    mineCounter++;
                }
            }

            return char.Parse(mineCounter.ToString());
        }
    }
}