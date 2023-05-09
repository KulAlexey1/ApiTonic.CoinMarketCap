namespace ApiTonic.CoinMarketCap.ClientLibrary.Models
{
    public class CmcCryptoList
    {
        public CmcStatus status { get; set; }
        public List<CmcCryptoListItem> data { get; set; }
    }
}
