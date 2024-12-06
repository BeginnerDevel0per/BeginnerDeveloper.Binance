using BeginnerDeveloper.Binance.Clients;
using BeginnerDeveloper.Binance.Clients.UsdFuturesApi;
using BeginnerDeveloper.Binance.Interfaces;
using BeginnerDeveloper.Binance.Interfaces.UsdFuturesApi;
using BeginnerDeveloper.Binance.Objects;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerDeveloper.Binance
{
    public static class BinanceServiceCollectionExtensions
    {

        public static IServiceCollection AddBinanceRestApi(this IServiceCollection services, Action<BinanceClientOptions> configureOptions = null)
        {
            services.AddHttpClient("BinanceFuturesApi", (ServiceCollection, configuration) =>
            {
                configuration.BaseAddress = new Uri("https://testnet.binancefuture.com");
            }
            );

            services.AddScoped<IBinanceRestApiAccount, BinanceRestApiAccount>();
            services.AddScoped<IBinanceRestApiTrade, BinanceRestApiTrade>();
            services.AddScoped<IBinanceRestApiMarketData, BinanceRestApiMarketData>();
          
            services.AddScoped(provider =>
            {
                var options = new BinanceClientOptions();
                configureOptions?.Invoke(options); 
                return options;
            });


            services.AddScoped<ICustomHttpClient, CustomHttpClient>();
            services.AddScoped<IBinanceClient, BinanceClient>();

            return services;
        }
    }
}

