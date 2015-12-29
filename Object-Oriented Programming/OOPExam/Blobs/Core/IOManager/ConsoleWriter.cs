using System;
using Blobs.Interfaces;

namespace Blobs.Core.IOManager
{
    public class ConsoleWriter : IOutputWriter
    {
        public void Print(string message)
        {
            Console.Write(message);
        }
    }
}