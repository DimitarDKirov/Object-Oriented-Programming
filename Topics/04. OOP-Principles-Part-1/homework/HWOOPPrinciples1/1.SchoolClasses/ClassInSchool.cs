using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class ClassInSchool : ICommentable
    {
        public List<Teacher> Teachers { get; set; }

        public List<Student> Students { get; set; }

        public string Identifier { get; set; }

        public string Comment { get; set; }
    }
}

