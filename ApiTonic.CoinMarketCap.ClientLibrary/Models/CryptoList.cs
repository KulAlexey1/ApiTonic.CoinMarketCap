namespace ApiTonic.CoinMarketCap.ClientLibrary.Models
{
    public class CryptoList
    {
        public Status status { get; set; }
        public List<CryptoListItem> data { get; set; }
    }
}
