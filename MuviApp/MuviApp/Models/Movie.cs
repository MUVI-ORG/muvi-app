using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class Movie
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
 /*Coming Soon properties*/
        [JsonPropertyName("runtimeMins")]
        public string RuntimeMins { get; set; }

        [JsonPropertyName("runtimeStr")]
        public string RuntimeStr { get; set; }

        [JsonPropertyName("plot")]
        public string Plot { get; set; }

        [JsonPropertyName("contentRating")]
        public string ContentRating { get; set; }

        [JsonPropertyName("metacriticRating")]
        public string MetacriticRating { get; set; }

        [JsonPropertyName("directors")]
        public string Directors { get; set; }

        [JsonPropertyName("stars")]
        public string Stars { get; set; }

        [JsonPropertyName("genres")]
        public string Genres { get; set; }
    }
    public class GenreList
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class DirectorList
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class StarList
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
