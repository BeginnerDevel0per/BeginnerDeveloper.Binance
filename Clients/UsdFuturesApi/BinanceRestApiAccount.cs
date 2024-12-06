using BeginnerDeveloper.Binance.Interfaces;
using BeginnerDeveloper.Binance.Interfaces.UsdFuturesApi;
using BeginnerDeveloper.Binance.Objects;
using BeginnerDeveloper.Binance.Objects.GeneralBinanceModels;
using BeginnerDeveloper.Binance.Objects.UsdFuturesApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Clients.UsdFuturesApi
{
    public class BinanceRestApiAccount : IBinanceRestApiAccount
    {
        private readonly BinanceClientOptions _options;
        private readonly ICustomHttpClient _httpClient;
        private readonly IBinanceRestApiMarketData _marketData;
        public BinanceRestApiAccount(BinanceClientOptions options, ICustomHttpClient httpClient, IBinanceRestApiMarketData marketData)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options));
            _httpClient = httpClient;
            _marketData = marketData;
        }
        public async Task<BinanceApiCustomResult<BinanceRestApiAccountInformationData>> AccountInformation()
        {
            var timestamp = (await _marketData.CheckServerTime()).Data?.ServerTime;
            if (timestamp == null)
                throw new ArgumentNullException(nameof(timestamp));

            Dictionary<string, object> query = new()
            {
               { "timestamp", timestamp },
               { "recvWindow", "5000" },
            };
            return await _httpClient.SendAsync<BinanceRestApiAccountInformationData>(HttpMethod.Get, "/fapi/v3/account", query, true);
        }

        public async Task<BinanceApiCustomResult<List<BinanceRestApiLeverageBracketData>>> LeverageBracket(string symbol)
        {
            var timestamp = (await _marketData.CheckServerTime()).Data?.ServerTime;
            if (timestamp == null)
                throw new ArgumentNullException(nameof(timestamp));

            Dictionary<string, object> query = new()
            {
               {"symbol",symbol } ,
               { "timestamp", timestamp },
               { "recvWindow", "5000" },
            };
            return await _httpClient.SendAsync<List<BinanceRestApiLeverageBracketData>>(HttpMethod.Get, "/fapi/v1/leverageBracket", query, true);
        }
    }
}
