using System;

namespace DefiningClasses_Exercise
{
    public class Dog
    {
        private string breed;
        private string name;

        public Dog() : this(null, null)
        {
            
        }

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public string Name { get; set; }

        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine("{0} ({1}) said: Bauuuuuu!", Name ?? "[unnamed dog]", Breed ?? "[unknown breed]");
        }

    }
}