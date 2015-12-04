using System;
using System.IO;

namespace _03.Path
{
    class PathMain
    {
        static void Main(string[] args)
        {
            Storage.LoadPathFromFile(@"..\..\text.txt");

            var fileContents = File.ReadAllText(@"..\..\Paths.txt");
            Console.WriteLine(fileContents);
        }
    }
}
