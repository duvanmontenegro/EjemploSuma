using Capacitacion.Infraestructura.Transversal.Exceptions;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Categories;

namespace Test.Capacitacion.Core.Transversal.GenericClass
{
    public class HttClientBaseUnitTest
    {
        [Fact]
        [UnitTest]
        public async Task Throws_UriFormatException_on_baseUrl_null_or_empty()
        {
            await Assert.ThrowsAsync<UriFormatException>(() => Task.FromResult(new FakeHttpClient("", new HttpClient()))).ConfigureAwait(false);
            await Assert.ThrowsAsync<UriFormatException>(() => Task.FromResult(new FakeHttpClient(null, new HttpClient()))).ConfigureAwait(false);
        }

        [Fact]
        [UnitTest]
        public async Task Throws_HttpClientNotDefinedException_on_httpClient_null()
        {
            await Assert.ThrowsAsync<HttpClientNotDefinedException>(() => Task.FromResult(new FakeHttpClient("http://any-url.com", null))).ConfigureAwait(false);
        }

        [Fact]
        [UnitTest]
        public async Task Put_Throws_NotImplementedException()
        {
            var client = new FakeHttpClient("http://any-url.com", new HttpClient());
            var responseEmpty = await Assert.ThrowsAsync<NotImplementedException>(() => Task.FromResult(client.Put("any-method", null))).ConfigureAwait(false);
        }

        [Fact]
        [UnitTest]
        public async Task Patch_Throws_NotImplementedException()
        {
            var client = new FakeHttpClient("http://any-url.com", new HttpClient());
            var responseEmpty = await Assert.ThrowsAsync<NotImplementedException>(() => Task.FromResult(client.Patch("any-method", null))).ConfigureAwait(false);
        }
    }
}
