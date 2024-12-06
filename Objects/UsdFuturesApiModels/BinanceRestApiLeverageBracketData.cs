using BeginnerDeveloper.Binance.Objects.GeneralBinanceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects.UsdFuturesApiModels
{
    public class BinanceRestApiLeverageBracketData
    {
        public string symbol { get; set; }
        public List<Bracket> brackets { get; set; }
    }
}
