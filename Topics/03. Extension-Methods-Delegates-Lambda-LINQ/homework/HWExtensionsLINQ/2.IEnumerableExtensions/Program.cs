//Problem 2. IEnumerable extensions
//    Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<int> collection = new HashSet<int>() { 23, 45, 1, 89, 2, 10, 8, 3};
            Console.WriteLine("Sum: {0}", collection.SumCol());
            Console.WriteLine("Product: {0}", collection.Product());
            Console.WriteLine("Min: {0}", collection.MinCol());
            Console.WriteLine("Max: {0}", collection.MaxCol());
            Console.WriteLine("Average: {0}", collection.AverageCol());
        }
    }
}
