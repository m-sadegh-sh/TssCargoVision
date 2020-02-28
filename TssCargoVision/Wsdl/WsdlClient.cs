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

        public async Task<TResponse> InvokeAsync<TRequest, TResponse>(TRequest request)
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

        //private TResponse UnwrapEnvelope<TResponse>(string input)
        //{
        //    var document = new XmlDocument();
        //    document.LoadXml(input);

        //    XmlNamespaceManager nsmgr = new XmlNamespaceManager(document.NameTable);
        //    nsmgr.AddNamespace("SOAP-ENV", "http://schemas.xmlsoap.org/soap/envelope/");
        //    nsmgr.AddNamespace("ns1", "http://tss.ir/cargoVision/service/index");

        //    return _xmlStreamSerializer.Deserialize<TResponse>(
        //        document.SelectSingleNode($"SOAP-ENV:Envelope/SOAP-ENV:Body/ns1:{typeof(TResponse).Name}", nsmgr).InnerXml
        //    );
        //}

        //private string WrapEnvelope<TBody>(TBody input)
        //{
        //    var action = typeof(TBody).Name.Replace("Request", string.Empty);
        //    var properties = input
        //        .GetType()
        //        .GetProperties(BindingFlags.Instance | BindingFlags.Public)
        //        .OfType<PropertyInfo>();

        //    var nameValues = properties
        //        .Select(p => $"<{p.Name}>{p.GetValue(input)}</{p.Name}>");

        //    var flattenedValues = string.Join(Environment.NewLine, nameValues);

        //    return $@"<?xml version=""1.0"" encoding=""UTF-8""?>
        //    <SOAP-ENV:Envelope xmlns:SOAP-ENV=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:ns1=""http://tss.ir/cargoVision/service/index"">
        //      <SOAP-ENV:Body>
        //        <ns1:{action}>
        //          <input>
        //            {flattenedValues}
        //          </input>
        //        </ns1:{action}>
        //      </SOAP-ENV:Body>
        //    </SOAP-ENV:Envelope>";
        //}

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
