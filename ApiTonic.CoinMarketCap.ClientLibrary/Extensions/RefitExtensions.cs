using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Refit;

namespace ApiTonic.CoinMarketCap.ClientLibrary.Extensions
{
    public static class RefitExtensions
    {
        public static RefitSettings GetNewtonsoftJsonRefitSettings()
            => new RefitSettings(
                new NewtonsoftJsonContentSerializer(
                    new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    })
               );
    }
}
