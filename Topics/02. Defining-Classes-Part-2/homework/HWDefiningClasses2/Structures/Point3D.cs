using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    [Serializable]
    struct Point3D
    {
        private static readonly Point3D o = new Point3D(0, 0, 0);

        public Point3D(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D O
        {
            get
            {
                return o;
            }
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public override string ToString()
        {
            return string.Format("{0};{1};{2}", this.X, this.Y, this.Z);
        }
    }

}
