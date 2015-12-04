using System;
using _02.Animals.Enums;

namespace _02.Animals.Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, Gender.Male)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The tomcat {0} says: Meow!", this.Name);
        }
    }
}