using System;
using System.Runtime.Serialization;

namespace Domain
{
    public class RegistreerException : Exception
    {
        public RegistreerException()
        {
        }

        public RegistreerException(string message) : base(message)
        {
        }

        public RegistreerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RegistreerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
