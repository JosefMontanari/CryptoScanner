using Newtonsoft.Json;

namespace CryptoScanner.Data.Models
{
    public class KryptoListRoot
    {


        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

    }
}
