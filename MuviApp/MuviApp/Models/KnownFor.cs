using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class KnownFor
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("fullTitle")]
        public string FullTitle { get; set; }

        [JsonPropertyName("year")]
        public string Year { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
}
