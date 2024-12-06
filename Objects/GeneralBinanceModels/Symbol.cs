using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects.GeneralBinanceModels
{
    public class Symbol
    {
        public string symbol { get; set; }
        public string pair { get; set; }
        public string contractType { get; set; }
        public long deliveryDate { get; set; }
        public long onboardDate { get; set; }
        public string status { get; set; }
        public string maintMarginPercent { get; set; }
        public string requiredMarginPercent { get; set; }
        public string baseAsset { get; set; }
        public string quoteAsset { get; set; }
        public string marginAsset { get; set; }
        public int pricePrecision { get; set; }
        public int quantityPrecision { get; set; }
        public int baseAssetPrecision { get; set; }
        public int quotePrecision { get; set; }
        public string underlyingType { get; set; }
        public List<string> underlyingSubType { get; set; }
        public int settlePlan { get; set; }
        public string triggerProtect { get; set; }
        public List<Filter> filters { get; set; }
        public List<string> OrderType { get; set; }
        public List<string> timeInForce { get; set; }
        public string liquidationFee { get; set; }
        public string marketTakeBound { get; set; }
    }
}
