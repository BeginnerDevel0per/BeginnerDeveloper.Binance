using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance
{
    public class BinanceAuthProvider
    {
        private string SecretKey { get; set; }
        private IDictionary<string, object> Params { get; set; }


        public BinanceAuthProvider(IDictionary<string, object> Params, string secretKey)
        {
            this.Params = Params ?? throw new ArgumentNullException(nameof(Params));
            this.SecretKey = secretKey ?? throw new ArgumentNullException(nameof(secretKey));
        }

        public string GenerateSignature()
        {
       
            var queryString = string.Join("&",
                Params
                    .OrderBy(p => p.Key)
                    .Select(p => $"{p.Key}={p.Value}"));
            return CreateSignature(queryString, SecretKey);
        }
        private string CreateSignature(string data, string secretKey)
        {
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secretKey)))
            {
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
    }
}
