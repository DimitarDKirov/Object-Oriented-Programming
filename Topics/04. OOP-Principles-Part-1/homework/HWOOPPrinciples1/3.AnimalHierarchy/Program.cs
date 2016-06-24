using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Tomcat[] tomcats = new Tomcat[]
            {
                new Tomcat("Tommy", 2),
                new Tomcat("Kotio", 5),
                new Tomcat("Acho", 7)
            };
            var tomcatsAge = tomcats.Average(t => t.Age);
            Console.WriteLine("Tomcats average age: {0:F2}", tomcatsAge);

            Kitten[] kittens = new Kitten[]
            {
                    new Kitten("Maca", 1),
                    new Kitten("Kote", 3)
             };
            var kittensAge = kittens.Average(k => k.Age);
            Console.WriteLine("Kittens average age: {0:F2}", kittensAge);

            Dog[] dogs = new Dog[]
            {
                new Dog("Sharo", 3, Gender.Male),
                new Dog("Ulichna", 2,Gender.Female),
                new Dog("Zvqr", 5,Gender.Male)
            };
            var dogsAge = dogs.Average(d => d.Age);
            Console.WriteLine("Dogs average age {0:F2}", dogsAge);

            Frog[] frogs = new Frog[]
            {
                new Frog("Krastava", 1, Gender.Male),
                new Frog("Petnista", 2, Gender.Female)
            };
            var frogsAge = frogs.Average(f => f.Age);
            Console.WriteLine("Frogs average age: {0:F2}", frogsAge);

            Animal[][] animals = new Animal[][]
            {
                tomcats,
                kittens,
                dogs,
                frogs
            };
            foreach (var animal in animals)
            {
                Console.WriteLine(animal[0].MakeSound());
            }
        }
    }
}
