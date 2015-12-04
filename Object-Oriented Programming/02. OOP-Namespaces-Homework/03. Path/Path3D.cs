using System.Collections.Generic;
using System.Linq;
using _01.Point3D;

namespace _03.Path
{
    public class Path3D
    {
        private List<Point3D> path = new List<Point3D>();

        public Path3D(List<Point3D> path)
        {
            this.Path = path;
        }

        public List<Point3D> Path
        {
            get { return path; }
            set { this.path = value ?? new List<Point3D>(); }
        }

        public void AddPointToPath(Point3D point)
        {
            var currentPath = path;
            currentPath.Add(point);
            this.path = currentPath;
        }

        public override string ToString()
        {
            return this.Path.Aggregate("\r\n", (current, point) => current + ("\t" + point.ToString() + "\r\n"));
        }
    }
}