using System;
using System.Collections.Generic;

namespace Predicates
{
    class PredicatesMain
    {
        static void Main(string[] args)
        {
            var nums = new List<int>() {1, 2, 3, 4, 5, 6, 7};

            Console.WriteLine(nums.FirstOrDefault(e => e % 2 == 0));
            Console.WriteLine(nums.FirstOrDefault(x => x < 0));
        }
    }
}
