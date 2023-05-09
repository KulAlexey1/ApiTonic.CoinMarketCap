namespace ApiTonic.CoinMarketCap.ClientLibrary.Models
{
    /// <summary>
    ///     "id": 1027,
    ///     "name": "Ethereum",
    ///     "symbol": "ETH",
    ///     "slug": "ethereum",
    ///     "token_address": "0xdac17f958d2ee523a2206206994597c13d831ec7"
    /// </summary>
    public class CmcPlatform
    {
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string slug { get; set; }
        public string token_address { get; set; }
    }
}
