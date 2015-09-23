using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CollectTheCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            int wallsHit = 0;
            int coinsCollected = 0;
            char[][] field = new char[4][];

            for (int i = 0; i < field.GetLength(0); i++)
            {
                field[i] = Console.ReadLine().ToCharArray();
            }

            int x = 0;
            int y = 0;
            char[] commands = Console.ReadLine().ToCharArray();

            for (int i = 0; i < commands.Length; i++)
            {
                if(commands[i] == 'v' || commands[i] == 'V')
                {
                    if(x == 3)
                    {
                        wallsHit++;
                    }
                    else if(field[x + 1].GetLength(0) <= y)
                    {
                        wallsHit++;
                    }
                    else
                    {
                        x++;
                        if(field[x][y] == '$')
                        {
                            coinsCollected++;
                            field[x][y] = ' ';
                        }
                    }
                }

                if (commands[i] == '^')
                {
                    if (x == 0)
                    {
                        wallsHit++;
                    }
                    else
                    {
                        x--;
                        if (field[x][y] == '$')
                        {
                            coinsCollected++;
                            field[x][y] = ' ';
                        }
                    }
                }

                if (commands[i] == '>')
                {
                    if (y == field[x].GetLength(0) - 1)
                    {
                        wallsHit++;
                    }
                    else
                    {
                        y++;
                        if (field[x][y] == '$')
                        {
                            coinsCollected++;
                            field[x][y] = ' ';
                        }
                    }
                }

                if (commands[i] == '<')
                {
                    if (y == 0)
                    {
                        wallsHit++;
                    }
                    else
                    {
                        y--;
                        if (field[x][y] == '$')
                        {
                            coinsCollected++;
                            field[x][y] = ' ';
                        }
                    }
                }
            }

            Console.WriteLine("Coins collected: {0}", coinsCollected);
            Console.WriteLine("Walls hit: {0}", wallsHit);

        }
    }
}
