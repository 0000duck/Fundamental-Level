using System;
using System.Collections.Generic;
using System.Linq;
using _01.Human__Student_and_Worker.People;

namespace _01.Human__Student_and_Worker
{
    class HumanStudentWorkerMain
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", "7890325403"),
                new Student("Stoqn", "Stoqnov", "7890325404"),
                new Student("Georgi", "Georgiev", "7890325402"),
                new Student("Angel", "Angelov", "7890325405")
            };

            var sortedStudents = students.OrderBy(x => x.FacultyNumber);
            Console.WriteLine("Ordered students by faculty number:");
            Console.WriteLine(String.Join("\n", sortedStudents));

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Petur", "Petrov", 5000, 8),
                new Worker("Marian", "Marianov", 2000, 4),
                new Worker("Hristo", "Hristov", 8000, 10),
                new Worker("Nikolai", "Nikolov", 700, 2)
            };

            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            Console.WriteLine("Ordered workers by payment per hour: ");
            Console.WriteLine(String.Join("\n", sortedWorkers));

            List<Human> people = new List<Human>();
            people.AddRange(students);
            people.AddRange(workers);

            var sortedPeople = people.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            Console.WriteLine("Ordered people by first name and last name: ");
            Console.WriteLine(String.Join("\n", sortedPeople));
        }
    }
}
