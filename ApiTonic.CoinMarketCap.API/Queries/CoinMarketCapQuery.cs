using ApiTonic.CoinMarketCap.ClientLibrary.Models;
using ApiTonic.CoinMarketCap.ClientLibrary.Services;

namespace ApiTonic.CoinMarketCap.API.Queries
{
    public class CoinMarketCapQuery
    {
        public Task<CmcCryptoList> GetLatestCryptoListAsync(
            [Service] ICryptoService service,
            int start,
            int limit,
            string convert)
        {
            return service.GetLatestListAsync(start, limit, convert);
        }
    }
}
