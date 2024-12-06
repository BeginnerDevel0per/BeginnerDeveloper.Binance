using BeginnerDeveloper.Binance.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance.Interfaces
{
    public interface ICustomHttpClient 
    {
        /// <summary>
        /// Binance için custom HttpClient nesnesi. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="httpMethod">Methodun türü (get,post,put,delete)</param>
        /// <param name="path">(urlnin yolu)</param>
        /// <param name="query">parametreler</param>
        /// <returns>Dönen değer generic T Sınıf nesnesi.</returns>
        Task<BinanceApiCustomResult<T>> SendAsync<T>(HttpMethod httpMethod, string path, Dictionary<string, object>? query = null,bool Auth=false) where T : class;
    }
}
