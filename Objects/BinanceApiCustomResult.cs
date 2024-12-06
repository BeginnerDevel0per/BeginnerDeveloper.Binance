using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Objects
{
    public class BinanceApiCustomResult<T> where T : class
    {
        public T? Data { get; set; }

        public BinanceApiErrorResponse? Error { get; set; }


        public  BinanceApiCustomResult<T> Success(T? data)
        {
            return new BinanceApiCustomResult<T>() { Data = data, Error = null };
        }

        public  BinanceApiCustomResult<T> Fail(BinanceApiErrorResponse? errorResponse)
        {
            return new BinanceApiCustomResult<T>() { Data = null, Error = errorResponse };
        }
    }
}
