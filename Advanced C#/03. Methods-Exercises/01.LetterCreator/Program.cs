using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LetterCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            string sender = Console.ReadLine();
            string receiver = Console.ReadLine();
            DateTime currentTime = DateTime.Now;

            PrintLetter(sender, receiver, currentTime);
        }

        static void PrintLetter(string sender, string receiver, DateTime currentTime)
        {
            Console.WriteLine("Dear {0}", receiver);
            Console.WriteLine("I hope I find you in good health.\nI need to inform you that the cheese has run away.\nSincerely, {0}", sender);
            Console.WriteLine("{0}", currentTime.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
        }
    }
}
