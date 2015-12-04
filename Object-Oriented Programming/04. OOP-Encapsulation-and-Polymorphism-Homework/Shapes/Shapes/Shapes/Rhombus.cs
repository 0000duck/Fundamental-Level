using System;

namespace Shapes.Shapes
{
    public class Rhombus : BasicShape
    {
        private double height;

        public Rhombus(double side, double height) : base(side, side)
        {
            this.Height = height;
        }

        public new double Height
        {
            get { return this.height; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Diagonal cannot be negative.");
                }

                this.height = value;
            }
        }

        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }

        public override double CalcualtePerimeter()
        {
            return 4 * this.Width;
        }
    }
}