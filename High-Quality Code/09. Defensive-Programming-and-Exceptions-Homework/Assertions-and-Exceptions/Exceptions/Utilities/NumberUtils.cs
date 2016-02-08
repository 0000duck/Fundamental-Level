using System;

namespace Exceptions_Homework.Utilities
{
    public static class NumberUtils
    {
        public static bool CheckPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}