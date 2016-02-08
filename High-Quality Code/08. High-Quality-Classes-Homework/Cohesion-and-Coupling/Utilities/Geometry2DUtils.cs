using System;

namespace CohesionAndCoupling.Utilities
{
    public class Geometry2DUtils
    {
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            var deltaX = (x2 - x1) * (x2 - x1);
            var deltaY = (y2 - y1) * (y2 - y1);

            double distance = Math.Sqrt(deltaX + deltaY);

            return distance;
        }
    }
}