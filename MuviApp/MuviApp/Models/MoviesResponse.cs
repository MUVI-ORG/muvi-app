using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace MuviApp.Models
{
    public class MoviesResponse
    {
        [JsonPropertyName("items")]
        public List<Movie> Movies { get; set; }

        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }

    }
}
