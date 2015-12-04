using System;

namespace Persons
{
    class PersonsMain
    {
        public static void Main(string[] args)
        {
            Console.Write("Please, enter a name: ");
            var name = Console.ReadLine();
            Console.Write("Please, enter a a value for age: ");
            var age = int.Parse(Console.ReadLine());
            Console.Write("Please, enter an email: ");
            var email = Console.ReadLine();

            Person firstPerson = new Person(name, age, email);
            //Person secondPerson = new Person("Stoqn", 22);

            Console.WriteLine(firstPerson.ToString());
            //Console.WriteLine(secondPerson.ToString());
        }
    }
}
