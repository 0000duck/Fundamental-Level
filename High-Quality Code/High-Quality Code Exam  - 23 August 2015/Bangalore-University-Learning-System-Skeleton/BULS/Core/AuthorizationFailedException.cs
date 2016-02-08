using System;

namespace BangaloreUniversityLearningSystem.Core
{
    public class AuthorizationFailedException : Exception
    {
        public AuthorizationFailedException(string message) : base(message)
        {
        }
    }
}