using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions_Homework.Utilities
{
    public static class SubsequenceUtils
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (startIndex < 0 || arr.Length <= startIndex)
            {
                throw new ArgumentOutOfRangeException("startIndex", "The start index should not be negative.");
            }

            if (count < 0 || count + startIndex > arr.Length)
            {
                throw new ArgumentOutOfRangeException("count", "Count should not be negative number.");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("count", "Count cannot e greater than string length.");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }
    }
}