using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }
        public Specialty Specialty { get; set; }

        public Student(string firstName, string lastName, string ssn)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = null;
        }

        public override bool Equals(object student)
        {
            Student anotherStudent = student as Student;
            if (!this.FirstName.Equals(anotherStudent.FirstName))
                return false;
            if (!this.LastName.Equals(anotherStudent.LastName))
                return false;
            if (this.SSN != anotherStudent.SSN)
                return false;
            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !student1.Equals(student2);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SSN.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder builer = new StringBuilder();
            builer.Append(this.FirstName);
            if (!string.IsNullOrEmpty(this.MiddleName))
                builer.Append(" " + this.MiddleName);
            builer.Append(this.LastName);
            builer.AppendFormat(", SSN: {0}", this.SSN);
            builer.AppendLine();


            return builer.ToString(); 

        }
    }
}
