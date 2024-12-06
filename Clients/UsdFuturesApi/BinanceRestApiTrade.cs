using BeginnerDeveloper.Binance.Enums;
using BeginnerDeveloper.Binance.Interfaces;
using BeginnerDeveloper.Binance.Interfaces.UsdFuturesApi;
using BeginnerDeveloper.Binance.Objects;
using BeginnerDeveloper.Binance.Objects.GeneralBinanceModels;
using BeginnerDeveloper.Binance.Objects.UsdFuturesApiModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Clients.UsdFuturesApi
{
    public class BinanceRestApiTrade : IBinanceRestApiTrade
    {

        private readonly BinanceClientOptions _options;
        private readonly ICustomHttpClient _httpClient;
        private readonly IBinanceRestApiMarketData _marketData;
        private readonly IBinanceRestApiAccount _account;
        public BinanceRestApiTrade(BinanceClientOptions options, ICustomHttpClient httpClient, IBinanceRestApiMarketData marketData, IBinanceRestApiAccount account)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options));
            _httpClient = httpClient;
            _marketData = marketData;
            _account = account;
        }

        public async Task<BinanceApiCustomResult<BinanceRestApiChangeInitialLeverageData>> ChangeInitialLeverage(string symbol, int leverage)
        {
            var timestamp = (await _marketData.CheckServerTime()).Data?.ServerTime;
            if (timestamp == null)
                throw new ArgumentNullException(nameof(timestamp));


            //max girilebilecek kaldıraç oranı
            var maxLeverage = (await _account.LeverageBracket(symbol)).Data?[0].brackets[0].initialLeverage;
            if (maxLeverage == null || leverage > maxLeverage)
                throw new Exception();

            Dictionary<string, object> query = new()
            {
               {"symbol",symbol } ,
               {"leverage",leverage},
               { "timestamp", timestamp },
               { "recvWindow", "5000" },
            };
            return await _httpClient.SendAsync<BinanceRestApiChangeInitialLeverageData>(HttpMethod.Post, "/fapi/v1/leverage", query, true);

        }

        public async Task<BinanceApiCustomResult<BinanceApiSuccessResponse>> ChangeMarginType(string symbol, MarginType marginType)
        {
            var timestamp = (await _marketData.CheckServerTime()).Data?.ServerTime;
            if (timestamp == null)
                throw new ArgumentNullException(nameof(timestamp));
            Dictionary<string, object> query = new()
            {
                 { "symbol", symbol },
                 { "timestamp", timestamp },
                 { "recvWindow", "5000" },
                 {"marginType",marginType }
            };
            return await _httpClient.SendAsync<BinanceApiSuccessResponse>(HttpMethod.Post, "/fapi/v1/marginType", query, true);
        }

        public async Task<BinanceApiCustomResult<BinanceApiSuccessResponse>> ChangeMultiAssetsMode(bool multiAssetsMargin)
        {
            var timestamp = (await _marketData.CheckServerTime()).Data?.ServerTime;
            if (timestamp == null)
                throw new ArgumentNullException(nameof(timestamp));
            Dictionary<string, object> query = new()
            {
                 { "timestamp", timestamp },
                 { "recvWindow", "5000" },
                 {"multiAssetsMargin",multiAssetsMargin }
            };
            return await _httpClient.SendAsync<BinanceApiSuccessResponse>(HttpMethod.Post, "/fapi/v1/multiAssetsMargin", query, true);
        }


        public async Task<BinanceApiCustomResult<BinanceRestApiNewOrderData>> NewOrder(string symbol, OrderType orderType, Side side, PositionSide positionSide, bool reduceOnly, decimal quantity)
        {
            var timestamp = (await _marketData.CheckServerTime()).Data?.ServerTime;
            if (timestamp == null)
                throw new ArgumentNullException(nameof(timestamp));

            Dictionary<string, object> query = new()
            {
                 { "symbol", symbol },
                 { "side", side },
                 { "positionSide", positionSide },
                 { "quantity", quantity.ToString(CultureInfo.InvariantCulture) },
                 { "timestamp", timestamp },
                 { "recvWindow", "5000" },
                 { "type", orderType},
            };
            return await _httpClient.SendAsync<BinanceRestApiNewOrderData>(HttpMethod.Post, "/fapi/v1/order", query, true);
        }

        public async Task<BinanceApiCustomResult<List<BinanceRestApiPositionInformationData>>> PositionInformation()
        {
            var timestamp = (await _marketData.CheckServerTime()).Data?.ServerTime;
            if (timestamp == null)
                throw new ArgumentNullException(nameof(timestamp));
            Dictionary<string, object> query = new()
            {
                 { "timestamp", timestamp },
                 { "recvWindow", "5000" },
            };
            return await _httpClient.SendAsync<List<BinanceRestApiPositionInformationData>>(HttpMethod.Get, "/fapi/v3/positionRisk", query, true);
        }
        public async Task<BinanceApiCustomResult<List<BinanceRestApiPositionInformationData>>> PositionInformation(string symbol)
        {
            var timestamp = (await _marketData.CheckServerTime()).Data?.ServerTime;
            if (timestamp == null)
                throw new ArgumentNullException(nameof(timestamp));
            Dictionary<string, object> query = new()
            {
                  { "symbol", symbol },
                 { "timestamp", timestamp },
                 { "recvWindow", "5000" },
            };
            return await _httpClient.SendAsync<List<BinanceRestApiPositionInformationData>>(HttpMethod.Get, "/fapi/v3/positionRisk", query, true);
        }

        public async Task<BinanceApiCustomResult<BinanceRestApiNewOrderData>> TestOrder(string symbol, OrderType orderType, Side side, PositionSide positionSide, bool reduceOnly, decimal quantity)
        {
            var timestamp = (await _marketData.CheckServerTime()).Data?.ServerTime;
            if (timestamp == null)
                throw new ArgumentNullException(nameof(timestamp));

            Dictionary<string, object> query = new()
            {
                 { "symbol", symbol },
                 { "side", side },
                 { "positionSide", positionSide },
                 { "quantity", quantity.ToString(CultureInfo.InvariantCulture) },
                 { "timestamp", timestamp },
                 { "recvWindow", "5000" },
                 { "type", orderType},
            };
            return await _httpClient.SendAsync<BinanceRestApiNewOrderData>(HttpMethod.Post, "/fapi/v1/order/test", query, true);
        }
    }
}
