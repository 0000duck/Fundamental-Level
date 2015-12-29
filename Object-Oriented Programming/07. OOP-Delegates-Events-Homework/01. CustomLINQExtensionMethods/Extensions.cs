using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CustomLINQExtensionMethods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> func)
        {
            return collection.Where(element => !func(element)).ToList();
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection,
            Func<TSource, TSelector> func) where TSelector : IComparable<TSelector>
        {
            TSelector max = func(collection.First());

            foreach (var element in collection.Where(e => max.CompareTo(func(e)) < 0))
            {
                max = func(element);
            }

            return max;
        }
    }
}