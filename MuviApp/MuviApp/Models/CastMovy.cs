using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class CastMovy
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("year")]
        public string Year { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
