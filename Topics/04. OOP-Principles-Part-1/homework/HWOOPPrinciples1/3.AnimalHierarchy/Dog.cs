using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Dog : Animal
    {
        public Dog(string name, int age, Gender gender) : base(name, age, gender)
        { }

        public override string MakeSound()
        {
            return "Dog " + this.Name + " barks";
        }
    }
}
