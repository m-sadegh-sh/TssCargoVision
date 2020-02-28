using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TssCargoVision.Configuration;

namespace TssCargoVision.Wsdl
{
    public class WsdlClient : IDisposable
    {
        private readonly UnderlyingConnectionOptions _underlyingConnectionOptions;
        private readonly HttpClient _httpClient;

        public WsdlClient(IOptions<UnderlyingConnectionOptions> underlyingConnectionOptions)
        {
            _underlyingConnectionOptions = underlyingConnectionOptions.Value;

            _httpClient = new HttpClient
            {
                BaseAddress = _underlyingConnectionOptions.ServiceUri,
                Timeout = _underlyingConnectionOptions.Timeout,
            };

            _httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(
                _underlyingConnectionOptions.UserAgentName,
                _underlyingConnectionOptions.UserAgentVersion
            ));
        }

        public async Task<TResponse> PostAsJsonAsync<TRequest, TResponse>(TRequest request)
        {
            var rawResponse = await _httpClient.PostAsJsonAsync(
                _underlyingConnectionOptions.ServiceUri,
                request
            );

            rawResponse.EnsureSuccessStatusCode();

            if (rawResponse.Content == null)
                throw new HttpRequestException("Called endpoint has no response.");

            return await rawResponse.Content.ReadAsAsync<TResponse>();
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
