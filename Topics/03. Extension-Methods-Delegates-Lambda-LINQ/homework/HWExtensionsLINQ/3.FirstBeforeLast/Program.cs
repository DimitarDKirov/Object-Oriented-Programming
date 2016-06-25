using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new[]
            {
                new Student() {FirstName="Pesho", LastName="Mitkov", Age=17 },
                new Student() {FirstName="Mitko", LastName="Petev" , Age=19},
                new Student() {FirstName="Georgi", LastName="Angelov", Age=24 },
                new Student() {FirstName= "Georgi",LastName="Georgiev", Age=22}
            };

            //Problem 3. First before last
            Console.WriteLine("Problem 3. First before last");
            var firstBeforeLast = from student in students
                                  where student.FirstName.CompareTo(student.LastName) < 0
                                  select student;

            foreach (var student in firstBeforeLast)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            //Problem 4. Age range
            Console.WriteLine("Problem 4. Age range");
            var ageRange = from student in students
                           where student.Age >= 18 && student.Age <= 24
                           select student;

            foreach (var student in ageRange)
            {
                Console.WriteLine("{0} {1}: {2}", student.FirstName, student.LastName, student.Age);
            }
            Console.WriteLine();

            //Problem 5. Order students
            Console.WriteLine("Problem 5. Order students");
            var orderedExtensions = students
                .OrderBy(st => st.FirstName)
                .ThenByDescending(st => st.LastName)
                .ToList();

            var orderedLINQ = from student in students
                              orderby student.FirstName ascending, student.LastName descending
                              select student;
            Console.WriteLine("\tExtension methods");
            foreach (var student in orderedExtensions)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine("\tLINQ");
            foreach (var student in orderedLINQ)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
