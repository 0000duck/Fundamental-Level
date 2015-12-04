using System;
using _02.Animals.Enums;

namespace _02.Animals.Animals
{
    abstract class Cat : Animal
    {
        protected Cat(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The cat {0} says: Meow!", this.Name);
        }
    }
}