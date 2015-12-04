using System;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D a, Point3D b)
        {
            var deltaX = a.X - b.X;
            var deltaY = a.Y - b.Y;
            var deltaZ = a.Z - b.Z;

            return Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);
        }
    }
}