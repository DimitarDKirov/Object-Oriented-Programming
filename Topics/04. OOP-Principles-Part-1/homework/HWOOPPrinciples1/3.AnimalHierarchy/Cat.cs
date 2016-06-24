using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Cat : Animal
    {
        protected Cat(string name, int age, Gender gender) : base(name, age, gender)
        {
        }
    }
}
