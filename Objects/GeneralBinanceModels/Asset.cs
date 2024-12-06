using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects.GeneralBinanceModels
{
    public class Asset
    {

        [JsonPropertyName("asset")]
        public string AssetName { get; set; }
        public bool MarginAvailable { get; set; }
        public double? autoAssetExchange { get; set; }
    }
}
