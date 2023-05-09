using ApiTonic.CoinMarketCap.API.Queries;

namespace ApiTonic.API.Queries
{
    public class Query
    {
        public CoinMarketCapQuery CoinMarketCap { get; set; } = new CoinMarketCapQuery();
    }
}
