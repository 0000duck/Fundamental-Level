using System;
using Methods.MethodsUtils;

namespace Methods
{
    public class Methods
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine(Calculations.CalculateTriangleArea(3, 4, 5));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
           
            
            Console.WriteLine(Formatting.NumberToDigit(5));

            try
            {
                Console.WriteLine(Calculations.FindMax(5, -1, 3, 2, 14, 2, 3));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }

            Console.WriteLine(Formatting.PrintAsNumber(1.3, "f"));
            Console.WriteLine(Formatting.PrintAsNumber(0.75, "%"));
            Console.WriteLine(Formatting.PrintAsNumber(2.30, "r"));

            Console.WriteLine("The distance between the two points is {0}", Calculations.CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + Calculations.IsHorizontalLine(3, 3));
            Console.WriteLine("Vertical? " + Calculations.IsVerticalLine(-1, 2.5));

            Student peter = new Student
            {
                FirstName = "Peter",
                LastName = "Ivanov"
            };
            peter.AdditionalInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student
            {
                FirstName = "Stella",
                LastName = "Markova"
            };
            stella.AdditionalInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
