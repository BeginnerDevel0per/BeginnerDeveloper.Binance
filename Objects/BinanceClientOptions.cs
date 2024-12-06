using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects
{
    public class BinanceClientOptions
    {
        public string PublicKey { get; set; } 
        public string SecretKey { get; set; }

        public BinanceClientOptions(string publicKey=null, string secretKey=null)
        {
            this.PublicKey = publicKey;
            this.SecretKey = secretKey;
        }
    }
}
