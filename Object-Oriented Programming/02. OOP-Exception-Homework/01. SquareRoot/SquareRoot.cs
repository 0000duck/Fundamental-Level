using System;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentNullException("input", "Input cannot be empty");
                }

                int number = int.Parse(input);

                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException("number", "Sqrt for negative numbers is undefined!");
                }
                Console.WriteLine("The square root of {0} is {1:F2}", number, Math.Sqrt(number));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
