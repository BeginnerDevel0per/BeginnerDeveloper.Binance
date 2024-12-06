using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects.UsdFuturesApiModels
{
    public class BinanceRestApiSymbolPriceData
    {
        public string symbol { get; set; }
        public decimal price { get; set; }
        public long time { get; set; }
    }
}
