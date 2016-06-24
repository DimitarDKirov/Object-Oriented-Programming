using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, Gender.Female)
        { }

        public override string MakeSound()
        {
            return this.Name + " kitten miau, miau";
        }
    }
}
