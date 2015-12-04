using System;
using Shapes.Interfaces;
using Shapes.Shapes;

namespace Shapes
{
    class ShapesMain
    {
        static void Main(string[] args)
        {
            IShape[] shapes = 
            {
                new Circle(3), 
                new Rectangle(5, 4),
                new Rhombus(8, 5)  
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateArea());
                Console.WriteLine(shape.CalcualtePerimeter());
            }
        }
    }
}
