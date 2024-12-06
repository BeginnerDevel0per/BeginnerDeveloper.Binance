using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects.UsdFuturesApiModels
{
    public class BinanceRestApiChangeInitialLeverageData
    {
        public int leverage { get; set; }
        public string maxNotionalValue { get; set; }
        public string symbol { get; set; }
    }
}
