using System;

namespace ExceptionHandling
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {

        }
    }
}
