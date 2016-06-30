//Problem 4. Person class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mitko = new Person("Mitko Kostov");
            Person ivan = new Person("Ivan Dimitrov", 22);
            Console.WriteLine(mitko);
            Console.WriteLine(ivan);
        }
    }
}
