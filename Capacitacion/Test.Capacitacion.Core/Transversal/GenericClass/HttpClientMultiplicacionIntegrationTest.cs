using Capacitacion.Core.Operaciones.Multiplicación;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Categories;

namespace Test.Capacitacion.Core.Transversal.GenericClass
{
    public class HttpClientMultiplicacionIntegrationTest
    {

            private const string _urlBase = "http://localhost:5000/Multiplicacion/";

            [Fact]
            [IntegrationTest]
            public async Task Get_HttpRequestException_on_fail()
            {
                var client = new FakeMultiplicacionHttpClient(_urlBase, new HttpClient());
                await Assert.ThrowsAsync<HttpRequestException>(() => client.Get("employees", null)).ConfigureAwait(false);
            }

            [Fact]
            [IntegrationTest]
            public async Task Post_Success_Response()
            {
                var client = new FakeMultiplicacionHttpClient(_urlBase, new HttpClient());
                var response = await client.Post("Multiplicar", new MultiplicacionDto { Factor1 = 1.ToString(), Factor2 = 2.ToString()}).ConfigureAwait(false);
                Assert.IsType<MultiplicacionDto>(response);
                Assert.NotNull(response);
                Assert.Equal(2, response.Resultado);
            }

            [Fact]
            [IntegrationTest]
            public async Task Get_422_status_code_on_fail()
            {
                var client = new FakeMultiplicacionHttpClient(_urlBase, new HttpClient());
                await Assert.ThrowsAsync<HttpRequestException>(() => client.Post("fake", null)).ConfigureAwait(false);
            }
        }
    }

