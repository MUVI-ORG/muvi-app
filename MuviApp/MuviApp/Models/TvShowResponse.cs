using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class TvShowResponse
    {
        [JsonPropertyName("items")]
        public List<TvShow> TvShows { get; set; }

        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }
    }
}
