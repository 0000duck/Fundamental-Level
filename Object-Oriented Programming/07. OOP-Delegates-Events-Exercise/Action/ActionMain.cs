using System;
using System.Collections.Generic;

namespace Action
{
    class ActionMain
    {
        static void Main(string[] args)
        {
            var nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            nums.ForEach(Console.WriteLine);
        }
    }
}
