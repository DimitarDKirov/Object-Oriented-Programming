//Problem 17. Longest string
//    Write a program to return the string with maximum length from an array of strings.
//    Use LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { "some", "longest", "test", "oki" };

            var longestString = array
                .Where(st => st.Length == array.Max(s => s.Length))
                .ToList()
                .First();
            Console.WriteLine(longestString);
        }
    }
}
