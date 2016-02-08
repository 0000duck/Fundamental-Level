using System;

namespace Theatre.Exceptions
{
    public class TimeDurationOverlapException : Exception
    {
        public TimeDurationOverlapException(string msg)
           : base(msg)
        {
        }
    }
}