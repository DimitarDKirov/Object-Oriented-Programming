using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Person
    {
        public string Name { get; set; }
        public byte? Age { get; set; }

        public Person(string name, byte? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", this.Name, this.Age.HasValue ? this.Age.Value.ToString() : "N/A");
        }
    }
}
