namespace Shapes.Shapes
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return this.Width*this.Height;
        }

        public override double CalcualtePerimeter()
        {
            return (2 * this.Width) + (2 * this.Height);
        }
    }
}