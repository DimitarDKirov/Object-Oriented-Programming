//Problem 2. Students and workers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Angel", "Angelov", 4.5f),
                new Student("Yanko", "Andreev", 3.2f),
                new Student("Ivan", "Georgiev", 5f),
                new Student("Peter", "Ivanov", 5.75f),
                new Student("Dimo", "Petrov", 2.6f),
                new Student("Mariq", "Dimova", 3.5f),
                new Student("Ralica", "Petkova", 3f),
                new Student("Pavel", "Kirov", 5.3f),
                new Student("Nadezda", "Dimitrova", 4.9f),
                new Student("Petko", "Dimov", 5.2f)
            };

            var orderedStudents = students
                .OrderBy(st => st.Grade)
                .ToList();

            Console.WriteLine(" Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).");
            foreach (var student in orderedStudents)
            {
                Console.WriteLine("{0} {1} grade: {2}", student.FirstName, student.LastName, student.Grade);
            }
            Console.WriteLine();

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Dragan", "Ivanov", 520.45),
                new Worker("Damyan", "Petrov", 280.17),
                new Worker("Pavel", "Sotirov", 328.58),
                new Worker("Vanq", "Dimova", 217.63),
                new Worker("Valq", "Ivanova", 195),
                new Worker("Simeon", "Borisov", 685.14),
                new Worker("Tsvetelina", "Petrova", 427.18),
                new Worker("Borislava", "Markova", 520.45),
                new Worker("Dragan", "Ivanov", 476.12),
                new Worker("Yordan", "Pavlov", 455.6) { WorkHoursPerDay=6},
            };
            Console.WriteLine("Initialize a list of 10 workers and sort them by money per hour in descending order.");
            var orderedWorkers = workers
                .OrderByDescending(w => w.MoneyPerHour())
                .ToList();
            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine("{0} {1} salary: {2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }
            Console.WriteLine();

            List<Human> people = new List<Human>(students);
            people.AddRange(workers);
            var sortedPeople = people
                .OrderBy(p => p.FirstName)
                .ThenBy(p => p.LastName)
                .ToList();
            Console.WriteLine("Merge the lists and sort them by first name and last name.");
            Console.WriteLine(string.Join(Environment.NewLine, sortedPeople));
        }
    }
}
