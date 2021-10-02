using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class GenreList
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
