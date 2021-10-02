using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class Actor
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("asCharacter")]
        public string AsCharacter { get; set; }
    }
}
