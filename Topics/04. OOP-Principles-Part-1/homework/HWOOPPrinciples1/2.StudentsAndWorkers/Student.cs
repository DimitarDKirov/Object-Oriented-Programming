using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Student : Human
    {
        private float grade;

        public Student(string firstName, string lastName, float grade) : base(firstName, lastName)
        {
            this.grade = grade;
        }

        public float Grade
        {
            get { return grade; }
            set { grade = value; }
        }

    }
}
