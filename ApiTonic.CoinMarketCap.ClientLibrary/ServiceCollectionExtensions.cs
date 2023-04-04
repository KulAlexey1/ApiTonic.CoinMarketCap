using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Refit;
using ApiTonic.CoinMarketCap.ClientLibrary.Models;
using ApiTonic.CoinMarketCap.ClientLibrary.Services;

namespace ApiTonic.CoinMarketCap.ClientLibrary
{
    public static class ServiceCollectionExtensions
    {
        public static void AddClientLibraryServices(this IServiceCollection services)
        {
            services.AddRefitClient<ICryptoService>(RefitExtensions.GetNewtonsoftJsonRefitSettings())
                .ConfigureHttpClient((serviceProvider, client) =>
                {
                    var apiSettings = serviceProvider.GetRequiredService<IOptions<ApiSettings>>().Value;

                    client.BaseAddress = new Uri(apiSettings.BaseAddress);
                    client.DefaultRequestHeaders.Add(apiSettings.HeaderApiKey, apiSettings.ApiKey);
                });
        }
    }
}
