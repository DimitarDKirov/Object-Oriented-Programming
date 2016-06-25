using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    abstract class Animal:ISound
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public virtual string MakeSound()
        {
            return "Animal make sound";
        }
    }
}
