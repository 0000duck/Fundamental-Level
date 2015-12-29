using System;
using System.Collections.Generic;

namespace Func
{
    class FuncMain
    {
        static void Main(string[] args)
        {
            var nums = new List<int>() {1, 2, 3, 4, 5, 6, 7};

            var result = nums.TakeWhile(e => e < 6);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
