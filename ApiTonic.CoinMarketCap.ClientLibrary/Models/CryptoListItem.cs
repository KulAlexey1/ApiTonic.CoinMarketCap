namespace ApiTonic.CoinMarketCap.ClientLibrary.Models
{
    /// <summary>
    ///     "id": 1027,
    ///     "name": "Ethereum",
    ///     "symbol": "ETH",
    ///     "slug": "ethereum",
    ///     "num_market_pairs": 6471,
    ///     "date_added": "2015-08-07T00:00:00.000Z",
    ///     "tags": [
    ///         "pos",
    ///         "smart-contracts",
    ///         "ethereum-ecosystem",
    ///         "coinbase-ventures-portfolio",
    ///         "three-arrows-capital-portfolio",
    ///         "polychain-capital-portfolio",
    ///         "binance-labs-portfolio",
    ///         "blockchain-capital-portfolio",
    ///         "boostvc-portfolio",
    ///         "cms-holdings-portfolio",
    ///         "dcg-portfolio",
    ///         "dragonfly-capital-portfolio",
    ///         "electric-capital-portfolio",
    ///         "fabric-ventures-portfolio",
    ///         "framework-ventures-portfolio",
    ///         "hashkey-capital-portfolio",
    ///         "kenetic-capital-portfolio",
    ///         "huobi-capital-portfolio",
    ///         "alameda-research-portfolio",
    ///         "a16z-portfolio",
    ///         "1confirmation-portfolio",
    ///         "winklevoss-capital-portfolio",
    ///         "usv-portfolio",
    ///         "placeholder-ventures-portfolio",
    ///         "pantera-capital-portfolio",
    ///         "multicoin-capital-portfolio",
    ///         "paradigm-portfolio",
    ///         "injective-ecosystem"
    ///     ],
    ///     "max_supply": null,
    ///     "circulating_supply": 122373866.2178,
    ///     "total_supply": 122373866.2178,
    ///     "platform": null,
    ///     "cmc_rank": 2,
    ///     "self_reported_circulating_supply": null,
    ///     "self_reported_market_cap": null,
    ///     "tvl_ratio": null,
    ///     "last_updated": "2023-02-18T14:44:00.000Z",
    ///     "quote": {
    ///         "USD": {
    ///             "price": 1693.5103964763584,
    ///             "volume_24h": 8187044153.852706,
    ///             "volume_change_24h": -27.8465,
    ///             "percent_change_1h": -0.19964097,
    ///             "percent_change_24h": 0.99421269,
    ///             "percent_change_7d": 11.30253106,
    ///             "percent_change_30d": 10.45331195,
    ///             "percent_change_60d": 39.69210684,
    ///             "percent_change_90d": 44.34933274,
    ///             "market_cap": 207241414696.85135,
    ///             "market_cap_dominance": 18.5755,
    ///             "fully_diluted_market_cap": 207241414696.85,
    ///             "tvl": null,
    ///             "last_updated": "2023-02-18T14:44:00.000Z"
    ///         }
    ///     }
    /// </summary>
    public class CryptoListItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string slug { get; set; }
        public int num_market_pairs { get; set; }
        public DateTime date_added { get; set; }
        public List<string> tags { get; set; }
        public long? max_supply { get; set; }
        public double circulating_supply { get; set; }
        public double total_supply { get; set; }
        public Platform platform { get; set; }
        public int cmc_rank { get; set; }
        public double? self_reported_circulating_supply { get; set; }
        public double? self_reported_market_cap { get; set; }
        public double? tvl_ratio { get; set; }
        public DateTime last_updated { get; set; }
        public Dictionary<string, Quote> quote { get; set; }
    }
}
