using System;
using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;

namespace PeekalinkSdk.DataContracts
{
    public class LinkPreview
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty("nextUpdate")]
        public DateTime NextUpdate { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("redirected")]
        public bool Redirected { get; set; }

        [JsonProperty("redirectionUrl")]
        public string RedirectionUrl { get; set; }

        [JsonProperty("redirectionCount")]
        public int RedirectionCount { get; set; }

        [JsonProperty("redirectionTrail")]
        public List<string> RedirectionTrail { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("trackersDetected")]
        public bool TrackersDetected { get; set; }

        [JsonProperty("icon")]
        public Icon Icon { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("details")]
        public Details Details { get; set; }
    }
}
