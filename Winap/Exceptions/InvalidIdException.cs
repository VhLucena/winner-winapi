using System;
namespace Winap.Exceptions
{
    public class InvalidIdException : Exception
    {
        public InvalidIdException()
            : base()
        {
            
        }

        public InvalidIdException(String message)
            : base(message)
        {
            
        }
    }
}