using BeginnerDeveloper.Binance.Clients.UsdFuturesApi;
using BeginnerDeveloper.Binance.Interfaces;
using BeginnerDeveloper.Binance.Interfaces.UsdFuturesApi;
using BeginnerDeveloper.Binance.Objects;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;


namespace BeginnerDeveloper.Binance
{
    public class CustomHttpClient : ICustomHttpClient
    {
        private readonly IHttpClientFactory httpClientFactory;
        private readonly BinanceClientOptions _options;
       
        public CustomHttpClient(BinanceClientOptions options, IHttpClientFactory httpClientFactory)
        {
            _options = options;
            this.httpClientFactory = httpClientFactory;
        }


        public async Task<BinanceApiCustomResult<T>> SendAsync<T>(HttpMethod httpMethod, string path, Dictionary<string, object>? query = null, bool Auth = false)
            where T : class
        {
            var client = httpClientFactory.CreateClient("BinanceFuturesApi");
            HttpRequestMessage requestMessage;

            if (Auth)
            {
             
                BinanceAuthProvider binanceAuthProvider = new BinanceAuthProvider(query, _options.SecretKey);
                var signature = binanceAuthProvider.GenerateSignature();    
                query.Add("signature", signature);
                var QueryParams = GenerateQueryParams(query);
                requestMessage = new HttpRequestMessage(httpMethod, path + QueryParams);
                requestMessage.Headers.Add("X-MBX-APIKEY", _options.PublicKey);
            }
            else
            {
                var QueryParams = GenerateQueryParams(query);
                requestMessage = new HttpRequestMessage(httpMethod, path + QueryParams);
            }

            var request = await client.SendAsync(requestMessage);
            if (request.IsSuccessStatusCode)
            {
                var data = await request.Content.ReadFromJsonAsync<T>();
                return new BinanceApiCustomResult<T>().Success(data);
            }
            else
            {
                var data = await request.Content.ReadFromJsonAsync<BinanceApiErrorResponse>();
                return new BinanceApiCustomResult<T>().Fail(data);
            }
        }

        private string GenerateQueryParams(Dictionary<string, object> query)
        {
            if (query == null || !query.Any())
                return string.Empty;
            var queryString = string.Join("&", query.OrderBy(p => p.Key).Select(p => $"{p.Key}={p.Value}"));
            return $"?{queryString}";
        }

    }
}
