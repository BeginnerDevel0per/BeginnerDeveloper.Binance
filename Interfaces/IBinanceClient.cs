using BeginnerDeveloper.Binance.Interfaces.UsdFuturesApi;
using BeginnerDeveloper.Binance.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Interfaces
{
    public interface IBinanceClient
    {
        /// <summary>
        /// binance docsdaki MarketData endpointlerine erişim.
        /// </summary>
        public IBinanceRestApiMarketData MarketData { get; }

        /// <summary>
        /// binance docsdaki Trade endpointlerine erişim.
        /// </summary>
        public IBinanceRestApiTrade Trade { get; }

        /// <summary>
        ///  binance docsdaki Account endpointlerine erişim.
        /// </summary>
        public IBinanceRestApiAccount Account { get; }

        /// <summary>
        /// Giriş gerektiren isteklerde binance secret key ve api key değerleri options içinde belirtilmeli.
        /// </summary>
        public BinanceClientOptions ClientOptions { get; set; }
    }
}
