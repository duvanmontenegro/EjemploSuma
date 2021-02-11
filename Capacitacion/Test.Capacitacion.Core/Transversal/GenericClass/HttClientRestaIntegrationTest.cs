using Capacitacion.Core.Operaciones.Restas;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Categories;

namespace Test.Capacitacion.Core.Transversal.GenericClass
{
    public class HttClientRestaIntegrationTest
    {
        private const string _urlBase = "http://localhost:5000/Resta/";

        [Fact]
        [IntegrationTest]
        public async Task Get_HttpRequestException_on_fail()
        {
            var client = new FakeRestaHttpClient(_urlBase, new HttpClient());
            await Assert.ThrowsAsync<HttpRequestException>(() => client.Get("employees", null)).ConfigureAwait(false);
        }

        [Fact]
        [IntegrationTest]
        public async Task Post_Success_Response()
        {
            var client = new FakeRestaHttpClient(_urlBase, new HttpClient());
            var response = await client.Post("Restar", new RestaDto { Minuendo = 1, Sustraendo = 2 }).ConfigureAwait(false);
            //Assert.IsType<RestaDto>(response);
            //Assert.NotNull(response);
            Assert.Equal(-1, response.Resultado);
        }

        [Fact]
        [IntegrationTest]
        public async Task Get_422_status_code_on_fail()
        {
            var client = new FakeRestaHttpClient(_urlBase, new HttpClient());
            await Assert.ThrowsAsync<HttpRequestException>(() => client.Post("fake", null)).ConfigureAwait(false);
        }
    }
}
