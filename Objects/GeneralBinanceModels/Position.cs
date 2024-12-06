using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects.GeneralBinanceModels
{
    public class Position
    {
        public string symbol { get; set; }
        public string positionSide { get; set; }
        public string positionAmt { get; set; }
        public string unRealizedProfit { get; set; }
        public string isolatedMargin { get; set; }
        public string notional { get; set; }
        public string isolatedWallet { get; set; }
        public string initialMargin { get; set; }
        public string maintMargin { get; set; } 
        public int adl { get; set; }    
        public object updateTime { get; set; }
    }
}
