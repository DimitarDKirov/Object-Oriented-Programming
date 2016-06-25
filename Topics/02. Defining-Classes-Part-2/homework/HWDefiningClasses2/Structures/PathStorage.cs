using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    static class PathStorage
    {
        public static void Save(string filename, Path path)
        {
            StreamWriter writer = new StreamWriter(filename);
            using (writer)
            {
                foreach (var point in path.Points)
                {
                    writer.WriteLine(point.ToString());
                }
            }
        }

        public static Path Load(string filename)
        {
            Path path = new Path();
            StreamReader reader = new StreamReader(filename);
            using (reader)
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    float[] coords = line.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(float.Parse).ToArray();
                    Point3D point = new Point3D(coords[0], coords[1], coords[2]);
                    path.AddPoint(point);
                }
            }

            return path;
        }
    }
}
