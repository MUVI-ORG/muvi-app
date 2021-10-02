using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class WriterList
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
