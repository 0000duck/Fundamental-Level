using System;

namespace _02.InterestCalculator
{
    public static class Extensions
    {
        public static void ValidateNum(dynamic num, string type)
        {
            if (num < 0)
            {
                throw new ArgumentException($"{type} sould be positive");
            }
        }
    }
}