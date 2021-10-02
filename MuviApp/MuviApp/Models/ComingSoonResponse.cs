using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class ComingSoonResponse
    {
        [JsonPropertyName("genreList")]
        public List<GenreList> GenreList { get; set; }

        [JsonPropertyName("directorList")]
        public List<DirectorList> DirectorList { get; set; }

        [JsonPropertyName("starList")]
        public List<StarList> StarList { get; set; }

        [JsonPropertyName("items")]
        public List<Movie> Movies { get; set; }
    }
}
