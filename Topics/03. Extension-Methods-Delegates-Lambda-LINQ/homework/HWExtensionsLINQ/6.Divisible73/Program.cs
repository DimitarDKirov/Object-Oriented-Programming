//Problem 6. Divisible by 7 and 3
//    Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions.Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible73
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 35, 21, 18, 3, 63, 14, 42, 50 };
            var divisibleExtension = array.Where(x => x % 7 == 0 && x % 3 == 0);
            Console.WriteLine("Divisible by 7 and 3 extensions: {0}", string.Join(", ", divisibleExtension));
            var divisibleLINQ = from number in array
                                where number % 3 == 0 && number % 7 == 0
                                select number;
            Console.WriteLine("Divisible by 7 and 3 LINQ: {0}", string.Join(", ", divisibleLINQ));
        }
    }
}
