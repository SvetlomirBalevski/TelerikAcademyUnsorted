using System.Collections.Generic;
using System.Text;

namespace HWDeffClass2
{
    class Path
    {
        // Only Implemented Adding To the List
        public List<Point3D> PathIn3D;
        public void Add(Point3D Point)
        {
            this.PathIn3D.Add(Point);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var path in this.PathIn3D)
            {
                sb.Append(path.ToString());
            }
            return sb.ToString();
        }
        
    }
}
