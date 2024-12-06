using BeginnerDeveloper.Binance.Interfaces;
using BeginnerDeveloper.Binance.Interfaces.UsdFuturesApi;
using BeginnerDeveloper.Binance.Objects;
using BeginnerDeveloper.Binance.Objects.UsdFuturesApiModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Clients.UsdFuturesApi
{
    public class BinanceRestApiMarketData : IBinanceRestApiMarketData
    {
        private readonly BinanceClientOptions _options;
        private readonly ICustomHttpClient _HttpClient;

        public BinanceRestApiMarketData(BinanceClientOptions options, ICustomHttpClient httpClient)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options));
            _HttpClient = httpClient;
        }
        public async Task<BinanceApiCustomResult<IEnumerable<BinanceRestApiSymbolPriceData>>> SymbolPriceTicker()
        {
            return await _HttpClient.SendAsync<IEnumerable<BinanceRestApiSymbolPriceData>>(HttpMethod.Get, "/fapi/v1/ticker/price");
        }

        public async Task<BinanceApiCustomResult<IEnumerable<BinanceRestApiPriceTicker24HrData>>> SymbolPriceTicker24Hr()
        {
            return await _HttpClient.SendAsync<IEnumerable<BinanceRestApiPriceTicker24HrData>>(HttpMethod.Get, "/fapi/v1/ticker/24hr");
        }
        public async Task<BinanceApiCustomResult<BinanceRestApiSymbolPriceData>> SymbolPriceTicker(string symbol)
        {
            Dictionary<string, object> query = new Dictionary<string, object>
            {
                { "symbol", symbol },
            };
            return await _HttpClient.SendAsync<BinanceRestApiSymbolPriceData>(HttpMethod.Get, "/fapi/v1/ticker/price", query);
        }
        public async Task<BinanceApiCustomResult<BinanceRestApiCheckServerTimeData>> CheckServerTime()
        {
            return await _HttpClient.SendAsync<BinanceRestApiCheckServerTimeData>(HttpMethod.Get, "/fapi/v1/time");
        }

        public async Task<BinanceApiCustomResult<BinanceRestApiExchangeInfoData>> ExchangeInfo()
        {
            return await _HttpClient.SendAsync<BinanceRestApiExchangeInfoData>(HttpMethod.Get, "/fapi/v1/exchangeInfo");
        }

        public async Task<BinanceApiCustomResult<BinanceRestApiExchangeInfoData>> ExchangeInfo(string symbol)
        {
            var result = await _HttpClient.SendAsync<BinanceRestApiExchangeInfoData>(HttpMethod.Get, "/fapi/v1/exchangeInfo");
            var infoForSymbol = result.Data.Symbols.FirstOrDefault(x => x.symbol == symbol);
            result.Data.Symbols.Clear();
            result.Data.Symbols.Add(infoForSymbol);
            return result;
        }
    }
}
