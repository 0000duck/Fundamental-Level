using System;

namespace Theatre.Exceptions
{
    public class DuplicateTheatreException : Exception
    {
        public DuplicateTheatreException(string msg)
            : base(msg)
        {
        }
    }
}