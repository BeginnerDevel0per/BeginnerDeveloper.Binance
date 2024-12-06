using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects.GeneralBinanceModels
{
    public class RateLimit
    {
        public string interval { get; set; }
        public int intervalNum { get; set; }
        public int limit { get; set; }
        public string rateLimitType { get; set; }
    }
}
