using System;
using System.Linq;
using _02.Animals.Animals;
using _02.Animals.Enums;

namespace _02.Animals
{
    class AnimalsMain
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[8]
            {
                new Dog("Sharo", 12, Gender.Male),
                new Frog("Froggy", 1, Gender.Female),
                new Kitten("Kitty", 3),
                new Kitten("Katya", 4),
                new Tomcat("Gosho", 5),
                new Tomcat("Assen", 2),
                new Frog("Hopper", 2, Gender.Female),
                new Dog("Murdzho", 17, Gender.Male),
            };

            var dogsAverageAge = animals.Where(x => x is Dog).Average(x => x.Age);
            Console.WriteLine("The average age of all dogs is: {0}", dogsAverageAge);

            var frogsAverageAge = animals.Where(x => x is Frog).Average(x => x.Age);
            Console.WriteLine("The average age of all frogs is: {0}", frogsAverageAge);

            var kittensAverageAge = animals.Where(x => x is Kitten).Average(x => x.Age);
            Console.WriteLine("The average age of all kittens is: {0}", kittensAverageAge);

            var tomcatsAverageAge = animals.Where(x => x is Tomcat).Average(x => x.Age);
            Console.WriteLine("The average age of all tomcats is: {0}", tomcatsAverageAge);
        }
    }
}
