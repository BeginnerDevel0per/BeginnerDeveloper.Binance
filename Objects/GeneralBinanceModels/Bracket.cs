using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects.GeneralBinanceModels
{
    public class Bracket
    {
        [JsonPropertyName("bracket")]
        public int bracketNotional { get; set; }
        public int initialLeverage { get; set; }
        public decimal notionalCap { get; set; }
        public decimal notionalFloor { get; set; }
        public decimal maintMarginRatio { get; set; }
        public decimal cum { get; set; }
    }
}
