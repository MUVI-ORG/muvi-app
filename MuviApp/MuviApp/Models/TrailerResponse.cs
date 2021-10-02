using System.Text.Json.Serialization;

namespace MuviApp.Models
{
    public class TrailerResponse
    {
        [JsonPropertyName("imDbId")]
        public string ImDbId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("fullTitle")]
        public string FullTitle { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("year")]
        public string Year { get; set; }

        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("videoTitle")]
        public string VideoTitle { get; set; }

        [JsonPropertyName("videoDescription")]
        public string VideoDescription { get; set; }

        [JsonPropertyName("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonPropertyName("uploadDate")]
        public string UploadDate { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("linkEmbed")]
        public string LinkEmbed { get; set; }

        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }
    }
}
