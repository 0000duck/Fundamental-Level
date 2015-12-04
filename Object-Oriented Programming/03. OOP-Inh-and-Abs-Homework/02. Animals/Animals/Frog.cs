using System;
using _02.Animals.Enums;

namespace _02.Animals.Animals
{
    class Frog : Animal
    {
        public Frog(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The frog {0} says: Ribbit!", this.Name);
        }
    }
}