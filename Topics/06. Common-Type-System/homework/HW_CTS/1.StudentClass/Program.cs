//Problem 1. Student class
//Problem 2. ICloneable
//Problem 3. IComparable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Mitko", "Petrov", "Goranov", "213456");
            Student student2 = new Student("Mitko", "Petrov", "Goranov", "111121")
            {
                Email = "mitko@aqbv.bg",
                Phone = "0888888",
                Course = 2,
                Specialty = Specialty.Computer_Sciences_and_Engineering,
                University = University.Technical_University_of_Varna,
                Faculty = Faculty.Faculty_Of_Computational_Engineering_And_Automation,
                Address = new Address() { Country = "Bulgaria", City = "Varna", AddressDetails = "h.c.Mladost" }
            };

            Student student3 = new Student("Pavel", "Valchev", "Petkov", "123111")
            {
                Email = "pavel@aqbv.bg",
                Phone = "0891111",
                Course = 1,
                Specialty = Specialty.Economics,
                University = University.University_of_National_and_World_Economiccs,
                Faculty = Faculty.International_Economics_And_Politics,
                Address = new Address() { Country = "Bulgaria", City = "Sofia", AddressDetails = "h.c.Luilin" }
            };
            Console.WriteLine("Equals");
            Console.WriteLine(student1.Equals(student2));
            Console.WriteLine(student2.Equals(student3));
            Console.WriteLine("GetHashCode");
            Console.WriteLine(student2.GetHashCode());
            Student student3Clone = (Student)student3.Clone();
            student3Clone.FirstName = "Asen";
            student3Clone.MiddleName = "Asenov";
            Console.WriteLine("Clone with updated FirstName and MiddleName");
            Console.WriteLine(student3);
            Console.WriteLine(student3Clone);
            Console.WriteLine("Sorting students uses IComparable");
            Student[] students = { student1, student2, student3, student3Clone };
            Array.Sort(students);
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
