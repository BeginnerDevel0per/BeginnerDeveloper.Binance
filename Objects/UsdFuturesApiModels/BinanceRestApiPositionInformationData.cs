using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects.UsdFuturesApiModels
{
    public class BinanceRestApiPositionInformationData
    {
        public string symbol { get; set; }
        public string positionSide { get; set; }
        public string positionAmt { get; set; }
        public string entryPrice { get; set; }
        public string breakEvenPrice { get; set; }
        public string markPrice { get; set; }
        public string unRealizedProfit { get; set; }
        public string liquidationPrice { get; set; }
        public string isolatedMargin { get; set; }
        public string notional { get; set; }
        public string marginAsset { get; set; }
        public string isolatedWallet { get; set; }
        public string initialMargin { get; set; }
        public string maintMargin { get; set; }
        public string positionInitialMargin { get; set; }
        public string openOrderInitialMargin { get; set; }
        public int adl { get; set; }
        public string bidNotional { get; set; }
        public string askNotional { get; set; }
        public object updateTime { get; set; }
    }
}
