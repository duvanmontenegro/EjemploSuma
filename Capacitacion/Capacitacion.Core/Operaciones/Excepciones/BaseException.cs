using System;
using System.Runtime.Serialization;

namespace Capacitacion.Core.Operaciones.Excepciones
{
    public class BaseException : Exception
    {
        public BaseException()
        {
        }

        public BaseException(string message) : base(message)
        {
        }

        protected BaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
