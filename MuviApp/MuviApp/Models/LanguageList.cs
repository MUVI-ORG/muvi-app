using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class LanguageList
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
