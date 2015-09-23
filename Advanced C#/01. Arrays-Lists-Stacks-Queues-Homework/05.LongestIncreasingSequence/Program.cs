using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LongestIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> output = new List<int>();
            List<int> longestS = new List<int>();

            while (nums.Count > 0)
            {
                output.Add(nums[0]);
                nums.Remove(nums[0]);

                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] > output[output.Count - 1])
                    {
                        output.Add(nums[i]);
                        nums.Remove(nums[i]);
                        i--;
                    }
                    else
                    {
                        break;
                    }
                }
                if (longestS.Count < output.Count)
                {
                    longestS.Clear();
                    longestS.InsertRange(0, output);
                }
                Console.WriteLine(String.Join(" ", output));
                output.Clear();
            }

            Console.WriteLine("Longest: " + String.Join(" ", longestS));
        }
    }
}
