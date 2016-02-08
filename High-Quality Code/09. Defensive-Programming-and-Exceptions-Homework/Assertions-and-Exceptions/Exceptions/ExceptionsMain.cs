using System;
using System.Collections.Generic;
using Exceptions_Homework.Exams;
using Exceptions_Homework.Utilities;

namespace Exceptions_Homework
{
    class ExceptionsMain
    {
        static void Main()
        {
            var substr = SubsequenceUtils.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = SubsequenceUtils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = SubsequenceUtils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = SubsequenceUtils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(SubsequenceUtils.ExtractEnding("I love C#", 2));
            Console.WriteLine(SubsequenceUtils.ExtractEnding("Nakov", 4));
            Console.WriteLine(SubsequenceUtils.ExtractEnding("beer", 4));
            Console.WriteLine(SubsequenceUtils.ExtractEnding("Hi", 100));

            Console.WriteLine("23 is {0}.", NumberUtils.CheckPrime(23) ? "prime" : "not prime");
            Console.WriteLine("33 is {0}.", NumberUtils.CheckPrime(33) ? "prime" : "not prime");

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalculateAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}