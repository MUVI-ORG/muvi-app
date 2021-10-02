using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class DirectorList
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
