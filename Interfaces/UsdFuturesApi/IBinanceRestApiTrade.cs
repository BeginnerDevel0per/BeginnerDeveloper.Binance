using BeginnerDeveloper.Binance.Enums;
using BeginnerDeveloper.Binance.Objects.UsdFuturesApiModels;
using BeginnerDeveloper.Binance.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Interfaces.UsdFuturesApi
{
    public interface IBinanceRestApiTrade
    {

        /// <summary>
        /// Futures(vadeli işlem) borsasına sipariş gönderir.
        /// </summary>
        /// <param name="symbol"></param>
        Task<BinanceApiCustomResult<BinanceRestApiNewOrderData>> NewOrder(string symbol, OrderType orderType, Side side, PositionSide positionSide, bool reduceOnly, decimal quantity);
        /// <summary>
        /// Sipariş talebini test etmek için kullanılır.
        /// </summary>
        /// <param name="symbol"></param>
        Task<BinanceApiCustomResult<BinanceRestApiNewOrderData>> TestOrder(string symbol, OrderType orderType, Side side, PositionSide positionSide, bool reduceOnly, decimal quantity);

        /// <summary>
        /// Güncel pozisyon bilgilerini al. 
        /// </summary>
        Task<BinanceApiCustomResult<List<BinanceRestApiPositionInformationData>>> PositionInformation();

        /// <summary>
        /// Sembole özel güncel pozisyon bilgilerini al. 
        /// </summary>
        /// <param name="symbol">Sembol adı</param>
        Task<BinanceApiCustomResult<List<BinanceRestApiPositionInformationData>>> PositionInformation(string symbol);

        /// <summary>
        /// Kullanıcının belirli sembol piyasasındaki başlangıç ​​kaldıracını değiştirin.
        /// </summary>
        /// <param name="symbol"></param>
        /// /// <param name="leverage">kaldıraç değeri girilmeli</param>
        Task<BinanceApiCustomResult<BinanceRestApiChangeInitialLeverageData>> ChangeInitialLeverage(string symbol, int leverage);

        /// <summary>
        /// Her sembolde kullanıcının çoklu varlık modunu değiştirir.
        /// önerilen tek varlık modu. örn: sadece USDT ile işlem.
        /// </summary>
        /// <param name="symbol"></param>
        Task<BinanceApiCustomResult<BinanceApiSuccessResponse>> ChangeMultiAssetsMode(bool multiAssetsMargin);


        /// <summary>
        /// Sembolun margin tipini değiştirir.IZOLATED, CROSSED
        /// </summary>
        /// <param name="marginType">Sembolün margin tipi</param>
        /// /// <param name="symbol"></param>
        Task<BinanceApiCustomResult<BinanceApiSuccessResponse>> ChangeMarginType(string symbol, MarginType marginType);
    }
}
