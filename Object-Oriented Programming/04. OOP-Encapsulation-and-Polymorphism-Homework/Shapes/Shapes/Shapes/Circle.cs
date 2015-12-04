using System;
using Shapes.Interfaces;

namespace Shapes.Shapes
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Radius cannot be negative.");
                }

                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI*this.Radius*this.Radius;
        }

        public double CalcualtePerimeter()
        {
            return 2*Math.PI*this.Radius;
        }
    }
}