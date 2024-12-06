using BeginnerDeveloper.Binance.Clients.UsdFuturesApi;
using BeginnerDeveloper.Binance.Interfaces;
using BeginnerDeveloper.Binance.Interfaces.UsdFuturesApi;
using BeginnerDeveloper.Binance.Objects;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Clients
{
    public class BinanceClient : IBinanceClient
    {
        public IBinanceRestApiMarketData MarketData { get; }

        public IBinanceRestApiTrade Trade { get; }

        public IBinanceRestApiAccount Account { get; }

        public BinanceClientOptions ClientOptions { get; set; } 

        public BinanceClient(BinanceClientOptions configureOptions, ICustomHttpClient httpClient)
        {

            ClientOptions = configureOptions;
            MarketData = new BinanceRestApiMarketData(ClientOptions, httpClient);
            Account = new BinanceRestApiAccount(ClientOptions, httpClient, MarketData);
            Trade = new BinanceRestApiTrade(ClientOptions, httpClient,MarketData,Account);
            

        }



    }
}
