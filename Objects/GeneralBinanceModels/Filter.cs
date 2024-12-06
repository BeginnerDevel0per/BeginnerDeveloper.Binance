using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects.GeneralBinanceModels
{
    public class Filter
    {
        public string filterType { get; set; }
        public string maxPrice { get; set; }
        public string minPrice { get; set; }
        public string tickSize { get; set; }
        public decimal maxQty { get; set; }
        public decimal minQty { get; set; }
        public decimal stepSize { get; set; }
        public int? limit { get; set; }
        public decimal notional { get; set; }
        public string multiplierUp { get; set; }
        public string multiplierDown { get; set; }
        public int? multiplierDecimal { get; set; }
    }
}
