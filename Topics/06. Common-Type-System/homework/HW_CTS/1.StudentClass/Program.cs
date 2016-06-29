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
            Student student1 = new Student("Mitko", "Petrov", "213456");
            Student student2 = new Student("Mitko", "Petrov", "213456")
            {
                MiddleName = "Goranov",
                Email = "mitko@aqbv.bg",
                Phone = "0888888",
                Course = 2,
                Specialty = Specialty.Computer_Sciences_and_Engineering,
                University = University.Technical_University_of_Varna,
                Faculty = Faculty.Faculty_Of_Computational_Engineering_And_Automation,
                Address = new Address() { Country = "Bulgaria", City = "Varna", AddressDetails = "h.c.Mladost" }
            };

            Student student3 = new Student("Pavel", "Valchev", "123111")
            {
                MiddleName = "Petkov",
                Email = "pavel@aqbv.bg",
                Phone = "0891111",
                Course = 1,
                Specialty = Specialty.Computer_Sciences_and_Engineering,
                University = University.Technical_University_of_Varna,
                Faculty = Faculty.Faculty_Of_Computational_Engineering_And_Automation,
                Address = new Address() { Country = "Bulgaria", City = "Sofia", AddressDetails = "h.c.Luilin" }
            };
            Console.WriteLine(student1.Equals(student2));
            Console.WriteLine(student2.Equals(student3));
            Console.WriteLine(student2.GetHashCode());
        }
    }
}
