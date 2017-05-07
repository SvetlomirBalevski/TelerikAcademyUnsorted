using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWDeffClass2
{
    public static class SavePoint
    {
        private static List<Point3D> allPoints;

        static SavePoint()
        {
            allPoints = new List<Point3D>();
        }

        public static void Save(Point3D point)
        {
            allPoints.Add(point);
        }

        public static List<Point3D> ReturnPoints()
        {
            return allPoints;
        }
    }
}
