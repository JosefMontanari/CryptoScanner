namespace CryptoScanner.Data.Models
{
    public class ViewModel
    {
        public string Name { get; set; } = null!;



        public int CurrentPrice { get; set; }

        public long MarketCap { get; set; }

        public DateTime AthDate { get; set; }

        public DateTime AtlDate { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
