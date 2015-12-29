using System;
using System.Collections.Generic;

namespace Func
{
    public static class Extensions
    {
        public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> collection, Func<T, bool> func)
        {
            var result = new List<T>();

            foreach (var element in collection)
            {
                if (func(element))
                {
                    result.Add(element);
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}