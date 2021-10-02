using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class StarList
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
