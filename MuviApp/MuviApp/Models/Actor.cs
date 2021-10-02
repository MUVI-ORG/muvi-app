using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class Actor
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("asCharacter")]
        public string AsCharacter { get; set; }
    }

  

    public class ListDirector
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class WriterList
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class ListStar
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
    public class ListGenre
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class ListCompany
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class CountryList
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class LanguageList
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class BoxOffice
    {
        [JsonPropertyName("budget")]
        public string Budget { get; set; }

        [JsonPropertyName("openingWeekendUSA")]
        public string OpeningWeekendUSA { get; set; }

        [JsonPropertyName("grossUSA")]
        public string GrossUSA { get; set; }

        [JsonPropertyName("cumulativeWorldwideGross")]
        public string CumulativeWorldwideGross { get; set; }
    }

    public class Similar
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("fullTitle")]
        public string FullTitle { get; set; }

        [JsonPropertyName("year")]
        public string Year { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("plot")]
        public string Plot { get; set; }

        [JsonPropertyName("directors")]
        public string Directors { get; set; }

        [JsonPropertyName("stars")]
        public string Stars { get; set; }

        [JsonPropertyName("genres")]
        public string Genres { get; set; }

        [JsonPropertyName("imDbRating")]
        public string ImDbRating { get; set; }
    }

}
