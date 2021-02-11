using Capacitacion.Core.Operaciones;
using Capacitacion.Infraestructura.Transversal.Exceptions;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Capacitacion.Infraestructura.Transversal.GenericMethods
{
    public class HttpBaseClientGenericMethods : IHttpBaseClientGenericMethods
    {
        private readonly string _baseUrl;
        private readonly HttpClient _client;

        public HttpBaseClientGenericMethods(string baseUrl, HttpClient client)
        {
            if (string.IsNullOrEmpty(baseUrl))
                throw new UriFormatException();

            _baseUrl = baseUrl;
            _client = client ?? throw new HttpClientNotDefinedException();
            _client.BaseAddress = new Uri(_baseUrl);
        }

        public async Task<T> Get<T>(string path, string request) where T : OperacionDto
        {
            ValidatePath(path);

            var response = await _client.GetAsync(path).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
        }

        public T Patch<T>(string path, T request) where T : OperacionDto
        {
            ValidatePath(path);
            throw new NotImplementedException();
        }

        public async Task<T> Post<T>(string path, T request) where T : OperacionDto
        {
            ValidatePath(path);
            var stringRequest = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _client.PostAsync(path, stringRequest).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
        }

        public T Put<T>(string path, T request) where T : OperacionDto
        {
            ValidatePath(path);
            throw new NotImplementedException();
        }

        private void ValidatePath(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException($"Parameter: {nameof(path)} required");
        }
    }
}
