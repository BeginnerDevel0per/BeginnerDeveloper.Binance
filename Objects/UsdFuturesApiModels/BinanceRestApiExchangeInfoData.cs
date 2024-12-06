using BeginnerDeveloper.Binance.Objects.GeneralBinanceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects.UsdFuturesApiModels
{
    public class BinanceRestApiExchangeInfoData
    {
        public List<object> ExchangeFilters { get; set; }
        public List<RateLimit> RateLimits { get; set; }
        public long ServerTime { get; set; }
        public List<Asset> Assets { get; set; }
        public List<Symbol> Symbols { get; set; }
        public string Timezone { get; set; }
    }
}
