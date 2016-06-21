//Problem 1. StringBuilder.Substring
//    Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder("test stringbuilder object");
            var result = builder.Substring(3, 150);
            Console.WriteLine(result.ToString());
        }
    }
}
