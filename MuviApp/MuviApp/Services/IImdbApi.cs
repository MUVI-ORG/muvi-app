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
        [Get(ApiConfig.BaseAdress)]
        Task<HttpResponseMessage> GetMostPopularMoviesAsync();

        // Get top coming soon movies
        [Get(ApiConfig.ComingSoon)]
        Task<HttpResponseMessage> GetComingSoonMoviesAsync();

        // Get a specific movie information
        [Get(ApiConfig.Title)]
        Task<HttpResponseMessage> GetTitleAsync(string movieId);

        // Get a movie trailer
        [Get(ApiConfig.Trailer)]
        Task<HttpResponseMessage> GetTrailerAsync(string movieId);

        [Get(ApiConfig.Actor)]
        Task<HttpResponseMessage> GetActorDetailAsync(string actorId);
    }
}
