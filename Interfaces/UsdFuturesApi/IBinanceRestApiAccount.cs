using BeginnerDeveloper.Binance.Objects;
using BeginnerDeveloper.Binance.Objects.UsdFuturesApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Interfaces.UsdFuturesApi
{
    public interface IBinanceRestApiAccount
    {
        /// <summary>
        /// Cari hesap bilgilerini döndürür.
        /// </summary>
        /// <returns></returns>
        Task<BinanceApiCustomResult<BinanceRestApiAccountInformationData>> AccountInformation();

        /// <summary>
        /// Sembolün kaldıraç oranını döndürür secretkey gerekli
        /// </summary>
        /// <param name="symbol"></param>
        Task<BinanceApiCustomResult<List<BinanceRestApiLeverageBracketData>>> LeverageBracket(string symbol);
    }
}
