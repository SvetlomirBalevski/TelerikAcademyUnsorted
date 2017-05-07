using System;

namespace HWDeffClass2
{
    static class CalculateDistance
    {
        public static double CalculateDist(Point3D First, Point3D Second)
        {
            double distance = 0;
            double temp = Math.Pow((First.Xcord - Second.Xcord), 2) +
                            Math.Pow((First.Ycord - Second.Ycord), 2) +
                            Math.Pow((First.Ycord - Second.Ycord), 2);
            distance = Math.Sqrt(temp);
            return distance;
        }
    }
}
