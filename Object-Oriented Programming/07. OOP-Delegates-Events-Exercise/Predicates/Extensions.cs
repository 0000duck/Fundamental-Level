using System;
using System.Collections.Generic;

namespace Predicates
{
    public static class Extensions
    {
        public static T FirstOrDefault<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            foreach (var element in collection)
            {
                if (predicate(element))
                {
                    return element;
                }
            }

            return default(T);
        }
    }
}