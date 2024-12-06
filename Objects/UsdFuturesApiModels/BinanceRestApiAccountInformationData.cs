using BeginnerDeveloper.Binance.Objects.GeneralBinanceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects.UsdFuturesApiModels
{
    public class BinanceRestApiAccountInformationData
    {
        public int feeTier { get; set; }
        public bool feeBurn { get; set; }
        public bool canTrade { get; set; }
        public bool canDeposit { get; set; }
        public bool canWithdraw { get; set; }
        public int updateTime { get; set; }
        public bool multiAssetsMargin { get; set; }
        public int tradeGroupId { get; set; }
        public string totalInitialMargin { get; set; }
        public string totalMaintMargin { get; set; }
        public string totalWalletBalance { get; set; }
        public string totalUnrealizedProfit { get; set; }
        public string totalMarginBalance { get; set; }
        public string totalPositionInitialMargin { get; set; }
        public string totalOpenOrderInitialMargin { get; set; }
        public string totalCrossWalletBalance { get; set; }
        public string totalCrossUnPnl { get; set; }
        public string availableBalance { get; set; }
        public string maxWithdrawAmount { get; set; }
        public List<Asset> assets { get; set; }
        public List<Position> positions { get; set; }
    }
}
