using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    abstract class Person : ICommentable
    {
        public string Comment { get; set; }

        public string Name { get; set; }
    }
}
