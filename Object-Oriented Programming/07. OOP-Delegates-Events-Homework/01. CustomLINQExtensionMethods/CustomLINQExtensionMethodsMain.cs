using System;
using System.Collections.Generic;

namespace _01.CustomLINQExtensionMethods
{
    class CustomLINQExtensionMethodsMain
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student("Pesho", 3),
                new Student("Gosho", 2),
                new Student("Mariika", 7),
                new Student("Stamat", 5)
            };

            Console.WriteLine(students.Max(student => student.Grade));
        }
    }
}
