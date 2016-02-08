namespace FactoryMethod
{
    using System;
    using Units;
    using TankFactories;

    public class Program
    {
        public static void Main()
        {
            TankFactory russianFactory = new RussianTankFactory();
            TankFactory germanFactory = new GermanTankFactory();
            TankFactory americanFactory = new AmericanTankFactory();

            var tiger = new Tank("Tiger", 4.5, 120);
            var t34 = new Tank("T 34", 3.3, 75);
            var m1Abrams = new Tank("M1 Abrams", 5.4, 120);

            Console.WriteLine(tiger);
            Console.WriteLine(t34);
            Console.WriteLine(m1Abrams);
        }
    }
}
