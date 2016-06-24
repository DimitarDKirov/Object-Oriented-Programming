using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Frog : Animal
    {
        public Frog(string name, int age, Gender gender) : base(name, age, gender)
        { }

        public override string MakeSound()
        {
            return string.Format("Frog {0} making sound", this.Name);
        }
    }
}
