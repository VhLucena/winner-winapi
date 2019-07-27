using System;
namespace Winap.Exceptions
{
    public class InvalidIdException : Exception
    {
        public InvalidIdException()
            : base()
        {
            
        }

        public InvalidIdException(string message)
            : base(message)
        {
            
        }
    }
}