namespace ApiTonic.CoinMarketCap.ClientLibrary.Models
{
    /// <summary>
    ///     "price": 1693.5103964763584,
    ///     "volume_24h": 8187044153.852706,
    ///     "volume_change_24h": -27.8465,
    ///     "percent_change_1h": -0.19964097,
    ///     "percent_change_24h": 0.99421269,
    ///     "percent_change_7d": 11.30253106,
    ///     "percent_change_30d": 10.45331195,
    ///     "percent_change_60d": 39.69210684,
    ///     "percent_change_90d": 44.34933274,
    ///     "market_cap": 207241414696.85135,
    ///     "market_cap_dominance": 18.5755,
    ///     "fully_diluted_market_cap": 207241414696.85,
    ///     "tvl": null,
    ///     "last_updated": "2023-02-18T14:44:00.000Z"
    /// </summary>
    public class Quote
    {
        public double price { get; set; }
        public double volume_24h { get; set; }
        public double volume_change_24h { get; set; }
        public double percent_change_1h { get; set; }
        public double percent_change_24h { get; set; }
        public double percent_change_7d { get; set; }
        public double percent_change_30d { get; set; }
        public double percent_change_60d { get; set; }
        public double percent_change_90d { get; set; }
        public double market_cap { get; set; }
        public double market_cap_dominance { get; set; }
        public double fully_diluted_market_cap { get; set; }
        public double? tvl { get; set; }
        public DateTime last_updated { get; set; }
    }
}
