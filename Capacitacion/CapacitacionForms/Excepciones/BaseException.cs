using System;
using System.Runtime.Serialization;

namespace CapacitacionForms.Excepciones
{
    public class BaseException : Exception
    {
        public BaseException(string message) : base(message)
        {
        }

        protected BaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
