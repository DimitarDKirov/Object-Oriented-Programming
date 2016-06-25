//Problem 1. Shapes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Triangle(10,20),
                new Rectangle(10,20),
                new Square(10)
            };

            Console.WriteLine("Shapes surface");
            foreach (var shape in shapes)
            {
                Console.WriteLine("{0} - {1}", shape.GetType().Name, shape.CalculateSurface());
            }

        }
    }
}
