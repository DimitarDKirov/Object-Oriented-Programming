using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Student : ICloneable, IComparable<Student>
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

        public Student(string firstName, string lastName, string middleName, string ssn)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
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
            builer.AppendFormat("{0} {1} {2}, SSN: {3}", this.FirstName, this.MiddleName, this.LastName, this.SSN);
            builer.AppendLine();
            builer.AppendLine("Address: " + this.Address);
            builer.AppendFormat("Phone: {0} Email: {1} Course: {2}", this.Phone, this.Email, this.Course != 0 ? this.Course.ToString() : "N/A");
            builer.AppendLine();
            builer.AppendFormat("{0} {1} {2}", this.University, this.Faculty, this.Specialty);
            builer.AppendLine();
            return builer.ToString();
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.LastName, this.MiddleName, this.SSN)
            {
                Address = this.Address.Clone() as Address,
                Phone = this.Phone,
                Email = this.Email,
                Course = this.Course,
                University = this.University,
                Faculty = this.Faculty,
                Specialty = this.Specialty
            };

        }

        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
                return this.FirstName.CompareTo(other.FirstName);
            if (this.LastName != other.LastName)
                return this.LastName.CompareTo(other.LastName);
            if (this.MiddleName != other.MiddleName)
                return this.MiddleName.CompareTo(other.MiddleName);

            return this.SSN.CompareTo(other.SSN);
        }
    }
}
