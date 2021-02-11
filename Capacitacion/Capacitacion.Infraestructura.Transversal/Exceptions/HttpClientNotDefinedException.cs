using System;
using System.Runtime.Serialization;

namespace Capacitacion.Infraestructura.Transversal.Exceptions
{
    public class HttpClientNotDefinedException : Exception
    {
        public HttpClientNotDefinedException()
        {
        }

        public HttpClientNotDefinedException(string message) : base(message)
        {
        }

        public HttpClientNotDefinedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
