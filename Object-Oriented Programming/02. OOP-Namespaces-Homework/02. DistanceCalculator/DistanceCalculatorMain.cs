using System;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    class DistanceCalculatorMain
    {
        static void Main(string[] args)
        {
            Point3D startPoint = new Point3D(-7, -4, 3);
            Point3D endPoint = new Point3D(17, 6, 2.5);

            Console.WriteLine(DistanceCalculator.CalculateDistance(startPoint, endPoint));
        }
    }
}
