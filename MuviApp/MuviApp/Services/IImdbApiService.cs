using MuviApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MuviApp.Services
{
    public interface IImdbApiService
    {
        Task<MoviesResponse> GetPopularMoviesAsync();
        Task<ComingSoonResponse> GetComingSoonMoviesAsync();
        Task<MovieInformationResponse> GetTitleAsync(string movieId);
        Task<TrailerResponse> GetTrailerAsync(string movieId);
        Task<ActorResponse> GetActorDetailAsync(string actorId);

    }
}
