//Problem 9. Student groups
//Problem 10. Student groups extensions
//Problem 11. Extract students by email
//Problem 12. Extract students by phone
//Problem 13. Extract students by marks
//Problem 14. Extract students with two marks
//Problem 15. Extract marks
//Problem 16.* Groups
//Problem 18. Grouped by GroupNumber
//Problem 19. Grouped by GroupName extensions

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_groups
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() {FirstName="Stoyan", LastName="Dimitrov", Tel="02855555", Email="stoyan@abv.bg", FN="555507", GroupNumber=2, Marks= new List<int>() {4,5,4,6 } },
                new Student() {FirstName="Angel", LastName="Petrov", Tel="088111111", Email="angel@gmail.com", FN="123406", GroupNumber=1, Marks= new List<int>() {3,4,5,2 } },
                new Student() {FirstName="Ivan", LastName="Ivanov", Tel="0282222", Email="ivan@abv.bg", FN="222205", GroupNumber=2, Marks= new List<int>() {6,5,6,6 } },
                new Student() {FirstName="Georgi", LastName="Angelov", Tel="02833333", Email="goro@yahoo.com", FN="333306", GroupNumber=2, Marks= new List<int>() {6,6,6,6} },
                new Student() {FirstName="Peter", LastName="Angelov", Tel="0884444", Email="pesho@abv.bg", FN="123406", GroupNumber=3, Marks= new List<int>() {2,3,4,2 } }
            };

            var studentsGroup2 = from student in students
                                 where student.GroupNumber == 2
                                 orderby student.FirstName
                                 select student;
            Console.WriteLine("Problem 9. Student groups. Select only the students that are from group number 2. Use LINQ query.Order the students by FirstName.");
            foreach (var student in studentsGroup2)
            {
                Console.WriteLine("{0} {1} - group {2}", student.FirstName, student.LastName, student.GroupNumber);
            }
            Console.WriteLine();

            Console.WriteLine("Problem 10. Student groups extensions");
            var studentsGroup2Exten = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName).ToList();
            Console.WriteLine("Problem 9. Student groups. Select only the students that are from group number 2. Use LINQ query.Order the students by FirstName.");
            foreach (var student in studentsGroup2Exten)
            {
                Console.WriteLine("{0} {1} - group {2}", student.FirstName, student.LastName, student.GroupNumber);
            }
            Console.WriteLine();

            Console.WriteLine("Problem 11. Extract students by email");
            var studentsAbvbg =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;
            foreach (var student in studentsAbvbg)
            {
                Console.WriteLine("{0} {1} - email {2}", student.FirstName, student.LastName, student.Email);
            }
            Console.WriteLine();

            Console.WriteLine("Problem 12. Extract students by phone");
            var sofiaStudents =
                from student in students
                where student.Tel.StartsWith("02")
                select student;
            foreach (var student in studentsAbvbg)
            {
                Console.WriteLine("{0} {1} - phone {2}", student.FirstName, student.LastName, student.Tel);
            }
            Console.WriteLine();

            Console.WriteLine("Problem 13. Extract students by marks");
            var studentsMark6 =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + ' ' + student.LastName, Marks = string.Join(", ", student.Marks) };
            foreach (var student in studentsMark6)
            {
                Console.WriteLine("{0} - marks {1}", student.FullName, student.Marks);
            }
            Console.WriteLine();

            Console.WriteLine("Problem 14. Extract students with two marks");
            var students2marks = students
                .Where(st => st.Marks
                .Count(m => m == 2) == 2)
                .ToList();
            foreach (var student in students2marks)
            {
                Console.WriteLine("{0} {1} - marks {2}", student.FirstName, student.LastName, string.Join(", ", student.Marks));
            }
            Console.WriteLine();

            Console.WriteLine("Problem 15.Extract marks");
            var studentsMarks = students
                .Where(st => st.FN.EndsWith("06"))
                .SelectMany(st => st.Marks)
                .ToList();
            Console.WriteLine(string.Join(", ", studentsMarks));
            Console.WriteLine();

            Console.WriteLine("Problem 18. Grouped by GroupNumber");
            var groupedbyGroupNumber =
                from student in students
                group student by student.GroupNumber;

            foreach (var group in groupedbyGroupNumber)
            {
                Console.WriteLine("GroupNumber {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("\t{0} {1}", student.FirstName, student.LastName);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Problem 19. Grouped by GroupName extensions");
            var GroupedExtensions = students
                .GroupBy(st => st.GroupNumber)
                .ToList();
            foreach (var group in groupedbyGroupNumber)
            {
                Console.WriteLine("GroupNumber {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("\t{0} {1}", student.FirstName, student.LastName);
                }
            }

            var groups = new List<Group>()
            {
                new Group() {DepartmentName= "Mathematics", GroupNumber=2},
                new Group() {DepartmentName= "Informatics", GroupNumber=1},
                new Group() {DepartmentName= "Engineering", GroupNumber=3},
            };
            Console.WriteLine();

            Console.WriteLine("Problem 16.* Groups");
            var mathStudents =
                from student in students
                join groupDep in groups on student.GroupNumber equals groupDep.GroupNumber
                where groupDep.DepartmentName == "Mathematics"
                select student;
            foreach (var student in mathStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}