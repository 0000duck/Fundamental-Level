using System;
using _02.Animals.Enums;

namespace _02.Animals.Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, Gender.Female)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The Kitten {0} says: Meow!", this.Name);
        }
    }
}