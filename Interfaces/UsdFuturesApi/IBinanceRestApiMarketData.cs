using BeginnerDeveloper.Binance.Objects;
using BeginnerDeveloper.Binance.Objects.UsdFuturesApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Interfaces.UsdFuturesApi
{
    public interface IBinanceRestApiMarketData
    {

        /// <summary>
        /// 24 saatlik hacim ve sembol bilgisini al.
        /// </summary>
        Task<BinanceApiCustomResult<IEnumerable<BinanceRestApiPriceTicker24HrData>>> SymbolPriceTicker24Hr();
        /// <summary>
        /// Sunucunun anlık zaman damgasını döner.
        /// </summary>
        Task<BinanceApiCustomResult<BinanceRestApiCheckServerTimeData>> CheckServerTime();
        /// <summary>
        /// Marketteki sembollerin anlık fiyatını döner.
        /// </summary>
        Task<BinanceApiCustomResult<IEnumerable<BinanceRestApiSymbolPriceData>>> SymbolPriceTicker();

        /// <summary>
        /// Marketteki parametreden alınan sembole göre anlık fiyatını döner.
        /// </summary>
        /// <param name="symbol">Kripto paranın sembolü verilmeli. Örn:BTCUSDT</param>
        Task<BinanceApiCustomResult<BinanceRestApiSymbolPriceData>> SymbolPriceTicker(string symbol);

        /// <summary>
        /// Güncel borsa işlem kuralları ve sembol bilgileri.
        /// </summary>
        Task<BinanceApiCustomResult<BinanceRestApiExchangeInfoData>> ExchangeInfo();
        /// <summary>
        /// Güncel borsa işlem kuralları ve sembol bilgileri.
        /// </summary>
        ///   /// <param name="symbol"></param>
        /// <returns></returns>
        Task<BinanceApiCustomResult<BinanceRestApiExchangeInfoData>> ExchangeInfo(string symbol);
    }
}
