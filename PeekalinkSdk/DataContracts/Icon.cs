using Newtonsoft.Json;

namespace PeekalinkSdk.DataContracts
{
    public class Icon
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }
}
