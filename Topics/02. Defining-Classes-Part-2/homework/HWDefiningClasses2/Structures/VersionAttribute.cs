using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    class VersionAttribute : Attribute
    {
        public int Major { get; set; }
        public int Minor { get; set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public override string ToString()
        {
            return string.Format("({0}.{1})", this.Major, this.Minor);
        }
    }
}
