using System;

namespace Winap.Exceptions
{
    public class EventException : Exception
    {
        public EventException()
            : base() { }

        public EventException(string message)
            : base(message) { }
    }

    public class EventAlreadyExistsException : EventException
    {
        public EventAlreadyExistsException()
            : base() { }
        
        public EventAlreadyExistsException(string message)
            : base(message) { }
    }

    public class EventDoesNotExistException : EventException
    {
        public EventDoesNotExistException()
            : base() { }

        public EventDoesNotExistException(string message)
            : base(message) { }
    }
}