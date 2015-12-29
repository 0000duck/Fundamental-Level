using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            BigInteger[] array = Regex.Split(input, "\\s+").Where(n => n!="").Select(n => BigInteger.Parse(n)).ToArray();
            string command = Console.ReadLine();
            long i = 0;
            while (command != "stop")
            {
                string[] commandArray = command.Split(' ');
                long offset = long.Parse(commandArray[0]);
                string operation = commandArray[1];
                long operand = long.Parse(commandArray[2]);
                offset = offset % array.Length;
                i += offset;
                int pos = i % array.Length;
                if (pos < 0)
                {
                    pos += array.Length;
                }
                if (pos >= array.Length)
                {
                    pos -= array.Length;
                }
                switch (operation)
                {
                    case "+":
                        if ((array[pos] + operand) < 0)
                        {
                            array[pos] = 0;
                        }
                        else
						{
							array[pos] = array[pos] + operand;
						}
                        break;
                    case "-":
                        if (array[pos] < operand)
                        {
                            array[pos] = 0;
                        }
                        else
						{
							array[pos] = array[pos] - operand;
						}
                        break;
                    case "*":
                        if ((array[pos] * operand) < 0)
                        {
                            array[pos] = 0;
                        }
                        else
						{
							array[pos] = array[pos] * operand;
						}
                        break;
                    case "/": 
                        if ((array[pos] / operand) < 0)
                        {
                            array[pos] = 0;
                        }
                        else
						{
							array[pos] = array[pos] / operand;
						}
                        break;
                    case "&":
                        if ((array[pos] & operand) < 0)
                        {
                            array[pos] = 0;
                        }
                        else 
						{
							array[pos] = array[pos] & operand;
						}
                        break;
                    case "|":
                        if ((array[pos] | operand) < 0)
                        {
                            array[pos] = 0;
                        }
                        else 
						{
							array[pos] = array[pos] | operand;
						}
                        break;
                    case "^": 
                        if ((array[pos] ^ operand) < 0)
                        {
                            array[pos] = 0;
                        }
                        else 
						{
							array[pos] = array[pos] ^ operand;
						}
                        break;
                }
                command = Console.ReadLine();
            }
            for (int n = 0; n < array.Length; n++)
            {
                if (array[n] < 0)
                {
                    array[n] = 0;
                }
            }
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }
    }
}