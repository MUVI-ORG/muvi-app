using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MuviApp.Services
{
    public interface IImdbApi
    {
        // Register and Get your API key here (More Info on Readme file)-> https://imdb-api.com/

        // Get top most popular movies
        [Get(APIConfig.BaseAdress)]
        Task<HttpResponseMessage> GetMostPopularMoviesAsync();

        // Get top coming soon movies
        [Get(APIConfig.ComingSoon)]
        Task<HttpResponseMessage> GetComingSoonMoviesAsync();

        // Get a specific movie information
        [Get(APIConfig.Title)]
        Task<HttpResponseMessage> GetTitleAsync(string movieId);

        // Get a movie trailer
        [Get(APIConfig.Trailer)]
        Task<HttpResponseMessage> GetTrailerAsync(string movieId);
    }
}
