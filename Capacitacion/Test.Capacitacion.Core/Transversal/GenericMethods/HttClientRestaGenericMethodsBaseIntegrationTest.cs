using Capacitacion.Core.Operaciones.Restas;
using Capacitacion.Core.Operaciones.Sumas;
using Capacitacion.Infraestructura.Transversal.GenericMethods;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Categories;

namespace Test.Capacitacion.Core.Transversal.GenericClass
{
    public class HttClientRestaGenericMethodsBaseIntegrationTest
    {
        private const string _urlBase = "http://localhost:5000/Resta/";


        [Fact]
        [IntegrationTest]
        public async Task Get_422_status_code_on_fail()
        {
            var client = new HttpBaseClientGenericMethods(_urlBase, new HttpClient());
            await Assert.ThrowsAsync<HttpRequestException>(() => client.Post<SumaDto>("fake", null)).ConfigureAwait(false);
        }

        [Fact]
        [IntegrationTest]
        public async Task Post_Success_Response()
        {
            var client = new HttpBaseClientGenericMethods(_urlBase, new HttpClient());
            var response = await client.Post("Restar", new RestaDto {  Minuendo = 1, Sustraendo= 2 }).ConfigureAwait(false);
            Assert.IsType<RestaDto>(response);
            Assert.NotNull(response);
            Assert.Equal(-1,response.Resultado);
        }

        
    }
}
