using Capacitacion.Core.Operaciones.Divisiones;
using Capacitacion.Core.Operaciones.Multiplicación;
using Capacitacion.Core.Operaciones.Restas;
using Capacitacion.Core.Operaciones.Sumas;
using Capacitacion.Infraestructura.Transversal.GenericClass;
using System.Net.Http;

namespace Test.Capacitacion.Core.Transversal.GenericClass
{
    public class FakeHttpClient : HttpBaseClientGenericClass<SumaDto>
    {
        public FakeHttpClient(string baseUrl, HttpClient client) : base(baseUrl, client)
        {
        }
    }
    public class FakeRestaHttpClient : HttpBaseClientGenericClass<RestaDto>
    {
        public FakeRestaHttpClient(string baseUrl, HttpClient client) : base(baseUrl, client)
        {
        }
    }
    public class FakeDivisionHttpClient : HttpBaseClientGenericClass<DivisionDto>
    {
        public FakeDivisionHttpClient(string baseUrl, HttpClient client) : base(baseUrl, client)
        {
        }
    }

    public class FakeMultiplicacionHttpClient : HttpBaseClientGenericClass<MultiplicacionDto>
    {
        public FakeMultiplicacionHttpClient(string baseUrl, HttpClient client) : base(baseUrl, client)
        {
        }
    }
}
