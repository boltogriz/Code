using System;

namespace _15_Exception
{
    class EngineIsDeadException : Exception
    {
        public EngineIsDeadException() { }
        public EngineIsDeadException(string message) : base(message) { }
        public EngineIsDeadException(string message, Exception inner) : base(message, inner) { }
    }
}
