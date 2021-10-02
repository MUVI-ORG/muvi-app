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
        [Get("/en/API/MostPopularMovies/PASTE_YOUR_API_KEY_HERE")]
        Task<HttpResponseMessage> GetMostPopularMoviesAsync();

        // Get top coming soon movies
        [Get("/en/API/ComingSoon/PASTE_YOUR_API_KEY_HERE")]
        Task<HttpResponseMessage> GetComingSoonMoviesAsync();

        // Get a specific movie information
        [Get("/en/API/Title/PASTE_YOUR_API_KEY_HERE/{movieId}")]
        Task<HttpResponseMessage> GetTitleAsync(string movieId);

        // Get a movie trailer
        [Get("/en/API/Trailer/PASTE_YOUR_API_KEY_HERE/{movieId}")]
        Task<HttpResponseMessage> GetTrailerAsync(string movieId);
    }
}
