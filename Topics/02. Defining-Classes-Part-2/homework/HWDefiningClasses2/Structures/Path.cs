using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Path
    {
        public Path()
        {
            this.Points = new List<Point3D>();
        }

        public List<Point3D> Points { get; private set; }

        public void AddPoint(Point3D point)
        {
            this.Points.Add(point);
        }
    }
}
