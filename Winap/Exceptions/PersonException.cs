using System;

namespace Winap.Exceptions
{
    public class PersonException : Exception
    {
        public PersonException()
            : base() { }

        public PersonException(string message)
            : base(message) { }
    }

    public class PersonAlreadyExistsException : PersonException
    {
        public PersonAlreadyExistsException()
            : base() { }
        
        public PersonAlreadyExistsException(string message)
            : base(message) { }
    }

    public class PersonDoesNotExistException : PersonException
    {
        public PersonDoesNotExistException()
            : base() { }

        public PersonDoesNotExistException(string message)
            : base(message) { }
    }
    
    
}