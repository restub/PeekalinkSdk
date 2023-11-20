using System;
using Newtonsoft.Json;

namespace PeekalinkSdk.DataContracts
{
    public class Details
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("videoId")]
        public string VideoId { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("viewCount")]
        public int ViewCount { get; set; }

        [JsonProperty("likeCount")]
        public int LikeCount { get; set; }

        [JsonProperty("dislikeCount")]
        public int DislikeCount { get; set; }

        [JsonProperty("commentCount")]
        public int CommentCount { get; set; }

        [JsonProperty("publishedAt")]
        public DateTime PublishedAt { get; set; }
    }
}
