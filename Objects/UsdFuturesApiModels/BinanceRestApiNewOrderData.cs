using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects.UsdFuturesApiModels
{
    public class BinanceRestApiNewOrderData
    {
        public string clientOrderId { get; set; }
        public string cumQty { get; set; }
        public string cumQuote { get; set; }
        public string executedQty { get; set; }
        public long? orderId { get; set; }
        public string avgPrice { get; set; }
        public string origQty { get; set; }
        public string price { get; set; }
        public bool reduceOnly { get; set; }
        public string side { get; set; }
        public string positionSide { get; set; }
        public string status { get; set; }
        public string stopPrice { get; set; }
        public bool closePosition { get; set; }
        public string symbol { get; set; }
        public string timeInForce { get; set; }
        public string type { get; set; }
        public string origType { get; set; }
        public string activatePrice { get; set; }
        public string priceRate { get; set; }
        public long updateTime { get; set; }
        public string workingType { get; set; }
        public bool priceProtect { get; set; }
        public string priceMatch { get; set; }
        public string selfTradePreventionMode { get; set; }
        public long goodTillDate { get; set; }
    }
}
