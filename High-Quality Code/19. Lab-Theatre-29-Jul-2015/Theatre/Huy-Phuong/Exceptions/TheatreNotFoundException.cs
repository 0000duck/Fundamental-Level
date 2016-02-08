using System;

namespace Theatre.Exceptions
{
    public class TheatreNotFoundException : Exception
    {
        public TheatreNotFoundException(string msg)
           : base(msg)
        {
        }
    }
}