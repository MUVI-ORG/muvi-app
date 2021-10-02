using System.Text.Json.Serialization;

namespace MuviApp.Models
{
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
}
