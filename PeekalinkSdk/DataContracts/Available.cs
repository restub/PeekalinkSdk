using Newtonsoft.Json;

namespace PeekalinkSdk.DataContracts
{
    public class Available
    {
        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }
    }
}
