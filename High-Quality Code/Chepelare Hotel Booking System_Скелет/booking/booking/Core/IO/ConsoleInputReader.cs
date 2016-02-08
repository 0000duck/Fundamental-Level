namespace HotelBookingSystem.Core.IO
{
    using System;
    using Interfaces;

    public class ConsoleInputReader : IInputReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}