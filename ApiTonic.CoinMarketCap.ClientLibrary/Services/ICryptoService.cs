using ApiTonic.CoinMarketCap.ClientLibrary.Models;
using Refit;

namespace ApiTonic.CoinMarketCap.ClientLibrary.Services
{
    public interface ICryptoService
    {
        [Get("/cryptocurrency/listings/latest?start={start}&limit={limit}&convert={convert}")]
        Task<CmcCryptoList> GetLatestListAsync(int start, int limit, string convert);
    }
}
