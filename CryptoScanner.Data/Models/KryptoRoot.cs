namespace CryptoScanner.Data.Models
{
    public class KryptoRoot
    {
        public class Root
        {
            [JsonProperty("id")]
            public string Id { get; set; }


            [JsonProperty("name")]
            public string Name { get; set; }



            [JsonProperty("current_price")]
            public int CurrentPrice { get; set; }

            [JsonProperty("market_cap")]
            public long MarketCap { get; set; }


            [JsonProperty("ath_date")]
            public DateTime AthDate { get; set; }


            [JsonProperty("atl_date")]
            public DateTime AtlDate { get; set; }



            [JsonProperty("last_updated")]
            public DateTime LastUpdated { get; set; }
        }

    }
}
