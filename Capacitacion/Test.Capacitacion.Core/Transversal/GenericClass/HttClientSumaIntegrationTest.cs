using Capacitacion.Core.Operaciones.Sumas;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Categories;

namespace Test.Capacitacion.Core.Transversal.GenericClass
{
    public class FakeData
    {
        public int Id { get; set; }
    }
    public class FakeStatusResponse
    {
        public string Status { get; set; }
        public FakeData Data { get; set; }
        public string Message { get; set; }
    }

    public class HttClientSumaIntegrationTest
    {
        private const string _urlBase = "http://localhost:5000/Suma/";

        [Fact]
        [IntegrationTest]
        public async Task Get_HttpRequestException_on_fail()
        {
            var client = new FakeHttpClient(_urlBase, new HttpClient());
            await Assert.ThrowsAsync<HttpRequestException>(() => client.Get("employees", null)).ConfigureAwait(false);
        }

        [Fact]
        [IntegrationTest]
        public async Task Post_Success_Response()
        {
            var client = new FakeHttpClient(_urlBase, new HttpClient());
            var response = await client.Post("Sumar", new SumaDto { Sumando1 = 1, Sumando2 = 2 }).ConfigureAwait(false);
            Assert.NotNull(response);
            Assert.Equal(3, response.Resultado);
        }

        [Fact]
        [IntegrationTest]
        public async Task Get_422_status_code_on_fail()
        {
            var client = new FakeHttpClient(_urlBase, new HttpClient());
            await Assert.ThrowsAsync<HttpRequestException>(() => client.Post("fake", null)).ConfigureAwait(false);
        }
    }
}
