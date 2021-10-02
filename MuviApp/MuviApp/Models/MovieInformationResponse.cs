using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace MuviApp.Models
{
    public class MovieInformationResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("originalTitle")]
        public string OriginalTitle { get; set; }

        [JsonPropertyName("fullTitle")]
        public string FullTitle { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("year")]
        public string Year { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("releaseDate")]
        public string ReleaseDate { get; set; }

        [JsonPropertyName("runtimeMins")]
        public string RuntimeMins { get; set; }

        [JsonPropertyName("runtimeStr")]
        public string RuntimeStr { get; set; }

        [JsonPropertyName("plot")]
        public string Plot { get; set; }

        [JsonPropertyName("plotLocal")]
        public string PlotLocal { get; set; }

        [JsonPropertyName("plotLocalIsRtl")]
        public bool PlotLocalIsRtl { get; set; }

        [JsonPropertyName("awards")]
        public string Awards { get; set; }

        [JsonPropertyName("directors")]
        public string Directors { get; set; }

        [JsonPropertyName("directorList")]
        public List<ListDirector> DirectorList { get; set; }

        [JsonPropertyName("writers")]
        public string Writers { get; set; }

        [JsonPropertyName("writerList")]
        public List<WriterList> WriterList { get; set; }

        [JsonPropertyName("stars")]
        public string Stars { get; set; }

        [JsonPropertyName("starList")]
        public List<ListStar> StarList { get; set; }

        [JsonPropertyName("actorList")]
        public List<Actor> ActorList { get; set; }

        [JsonPropertyName("fullCast")]
        public object FullCast { get; set; }

        [JsonPropertyName("genres")]
        public string Genres { get; set; }

        [JsonPropertyName("genreList")]
        public List<ListGenre> GenreList { get; set; }

        [JsonPropertyName("companies")]
        public string Companies { get; set; }

        [JsonPropertyName("companyList")]
        public List<ListCompany> CompanyList { get; set; }

        [JsonPropertyName("countries")]
        public string Countries { get; set; }

        [JsonPropertyName("countryList")]
        public List<CountryList> CountryList { get; set; }

        [JsonPropertyName("languages")]
        public string Languages { get; set; }

        [JsonPropertyName("languageList")]
        public List<LanguageList> LanguageList { get; set; }

        [JsonPropertyName("contentRating")]
        public string ContentRating { get; set; }

        [JsonPropertyName("imDbRating")]
        public string ImDbRating { get; set; }

        [JsonPropertyName("imDbRatingVotes")]
        public string ImDbRatingVotes { get; set; }

        [JsonPropertyName("metacriticRating")]
        public string MetacriticRating { get; set; }

        [JsonPropertyName("ratings")]
        public object Ratings { get; set; }

        [JsonPropertyName("wikipedia")]
        public object Wikipedia { get; set; }

        [JsonPropertyName("posters")]
        public object Posters { get; set; }

        [JsonPropertyName("images")]
        public object Images { get; set; }

        [JsonPropertyName("trailer")]
        public object Trailer { get; set; }

        [JsonPropertyName("boxOffice")]
        public BoxOffice BoxOffice { get; set; }

        [JsonPropertyName("tagline")]
        public string Tagline { get; set; }

        [JsonPropertyName("keywords")]
        public string Keywords { get; set; }

        [JsonPropertyName("keywordList")]
        public List<string> KeywordList { get; set; }

        [JsonPropertyName("similars")]
        public List<Similar> Similars { get; set; }

        [JsonPropertyName("tvSeriesInfo")]
        public object TvSeriesInfo { get; set; }

        [JsonPropertyName("tvEpisodeInfo")]
        public object TvEpisodeInfo { get; set; }

        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }

    }
}
