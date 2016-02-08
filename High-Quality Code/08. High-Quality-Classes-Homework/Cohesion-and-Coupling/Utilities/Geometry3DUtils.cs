using System;

namespace CohesionAndCoupling.Utilities
{
    public class Geometry3DUtils
    {
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            var deltaX = (x2 - x1) * (x2 - x1);
            var deltaY = (y2 - y1) * (y2 - y1);
            var deltaZ = (z2 - z1) * (z2 - z1);

            double distance = Math.Sqrt(deltaX + deltaY + deltaZ);

            return distance;
        }

        public static double CalcVolume(Figure3D figure)
        {
            double volume = figure.Width * figure.Height * figure.Depth;

            return volume;
        }

        public static double CalcDiagonalXYZ(Figure3D figure)
        {
            double distance = CalcDistance3D(0, 0, 0, figure.Width, figure.Height, figure.Depth);

            return distance;
        }

        public static double CalcDiagonalXY(Figure3D figure)
        {
            double distance = Geometry2DUtils.CalcDistance2D(0, 0, figure.Width, figure.Height);

            return distance;
        }

        public static double CalcDiagonalXZ(Figure3D figure)
        {
            double distance = Geometry2DUtils.CalcDistance2D(0, 0, figure.Width, figure.Depth);

            return distance;
        }

        public static double CalcDiagonalYZ(Figure3D figure)
        {
            double distance = Geometry2DUtils.CalcDistance2D(0, 0, figure.Height, figure.Depth);

            return distance;
        }
    }
}