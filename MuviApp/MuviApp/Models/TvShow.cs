using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class TvShow
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("rank")]
        public string Rank { get; set; }

        [JsonPropertyName("rankUpDown")]
        public string RankUpDown { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("fullTitle")]
        public string FullTitle { get; set; }

        [JsonPropertyName("year")]
        public string Year { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("crew")]
        public string Crew { get; set; }

        [JsonPropertyName("imDbRating")]
        public string ImDbRating { get; set; }

        [JsonPropertyName("imDbRatingCount")]
        public string ImDbRatingCount { get; set; }
    }
}
