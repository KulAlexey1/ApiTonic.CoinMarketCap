using ApiTonic.CoinMarketCap.ClientLibrary.Models;
using ApiTonic.CoinMarketCap.ClientLibrary.Services;

namespace ApiTonic.API.Queries
{
    public class Query
    {
        public Task<CryptoList> GetLatestCryptoListAsync(
            [Service] ICryptoService service,
            int start,
            int limit,
            string convert)
        {
            return service.GetLatestListAsync(start, limit, convert);
        }
    }
}
