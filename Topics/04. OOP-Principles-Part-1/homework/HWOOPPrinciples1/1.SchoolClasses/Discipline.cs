using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Discipline : ICommentable
    {
        public string Name { get; set; }

        public int NumberOfLectures { get; set; }

        public int NumberOfExcercises { get; set; }

        public string Comment { get; set; }
    }
}
