using System;
using System.Runtime.Serialization;

namespace Domain
{
    public class GarageException : Exception
    {
        public GarageException()
        {
        }

        public GarageException(string message) : base(message)
        {
        }

        public GarageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GarageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
