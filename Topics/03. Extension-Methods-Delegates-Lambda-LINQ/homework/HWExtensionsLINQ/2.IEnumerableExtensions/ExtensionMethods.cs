using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    public static class ExtensionMethods
    {
        public static T SumCol<T>(this IEnumerable<T> collection)
        {
            T result = default(T);
            foreach (var item in collection)
            {
                result += (dynamic)item;
            }
            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic result = 1;
            foreach (var item in collection)
            {
                result *= (dynamic)item;
            }
            return result;
        }

        public static T MinCol<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T min = collection.FirstOrDefault();
            foreach (var item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T MaxCol<T>(this IEnumerable<T> collection) where T : IComparable
        {
            return collection.Max();
        }

        public static T AverageCol<T>(this IEnumerable<T> collection)
        {
            return (dynamic)collection.SumCol() / collection.Count();
        }
    }
}
