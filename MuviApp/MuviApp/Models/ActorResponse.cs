using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class ActorResponse
    {

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        [JsonPropertyName("birthDate")]
        public string BirthDate { get; set; }

        [JsonPropertyName("deathDate")]
        public object DeathDate { get; set; }

        [JsonPropertyName("awards")]
        public string Awards { get; set; }

        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("knownFor")]
        public List<KnownFor> KnownFor { get; set; }

        [JsonPropertyName("castMovies")]
        public List<CastMovy> CastMovies { get; set; }

        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }

    }
}
