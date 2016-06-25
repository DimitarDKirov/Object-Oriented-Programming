using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1. Structure");
            Console.WriteLine(Point3D.O);

            Point3D a = new Point3D(1, 2, 4);
            Point3D b = new Point3D(5, -2, 1);
            Point3D c = new Point3D(1.23f, 3.33f, 5.01f);

            double distanceAB = DistanceCalculator.CalculateDistance(a, b);
            Console.WriteLine(distanceAB);
            Path path = new Path();
            path.AddPoint(a);
            path.AddPoint(b);
            path.AddPoint(c);
            string file = "points.txt";
            PathStorage.Save(file, path);
            Path loaded = PathStorage.Load(file);
            foreach (var point in loaded.Points)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine("\nProblem 5. Generic class\n");

            GenericList<int> list = new GenericList<int>(3);
            for (int i = 0; i < 5; i++)
            {
                list.Add(i + 1);
            }
            Console.WriteLine("Initial list with resize");
            Console.WriteLine(list.ToString());
            list[2] = 100;
            Console.WriteLine("Element at index 2 updated with indexer");
            Console.WriteLine(list[2]);
            Console.WriteLine(list.ToString());
            Console.WriteLine("Find element 5");
            Console.WriteLine(list.Find(5));
            Console.WriteLine("Insert 500 at position 1");
            list.Insert(1, 500);
            Console.WriteLine(list.ToString());
            Console.WriteLine("Min and Max element");
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());

            Console.WriteLine("Problem 8.Matrix");
            Matrix<int> matrixA = new Matrix<int>(3, 3);
            Matrix<int> matrixB = new Matrix<int>(3, 3);
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    matrixA[row, col] = row + col + 1;
                    matrixB[row, col] = (row + 1) * (col + 1);
                }
            }
            Console.WriteLine("Matrix A");
            Console.WriteLine(matrixA);
            Console.WriteLine("Matrix B");
            Console.WriteLine(matrixB);
            var sum = matrixA + matrixB;
            Console.WriteLine("Matrix sum");
            Console.WriteLine(sum);
            var substr = matrixA - matrixB;
            Console.WriteLine("Matrix subtraction ");
            Console.WriteLine(substr);
            var multiply = matrixA * matrixB;
            Console.WriteLine("Matrix multiplication");
            Console.WriteLine(multiply);
            if (substr) Console.WriteLine(true);
            else Console.WriteLine(false);

            Console.WriteLine("Attribute");
            Console.WriteLine(matrixA.Attribute());

        }
    }
}
