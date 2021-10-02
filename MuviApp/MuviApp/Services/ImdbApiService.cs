﻿using MuviApp.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MuviApp.Services
{
    public class ImdbApiService : IImdbApiService
    {
        public ImdbApiService(IJsonSerializerService serializer)
        {
            _imdbApi = RestService.For<IImdbApi>(APIConfig.ApiKey);
            _serializer = serializer;
        }

        public async Task<MoviesResponse> GetPopularMoviesAsync()
        {
            var response = await _imdbApi.GetMostPopularMoviesAsync();

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                var moviesResponse = _serializer.Deserialize<MoviesResponse>(responseString);

                return moviesResponse;
            }
            return null;
        }

        public async Task<ComingSoonResponse> GetComingSoonMoviesAsync()
        {
            var response = await _imdbApi.GetComingSoonMoviesAsync();

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                var comingSoonMoviesResponse = _serializer.Deserialize<ComingSoonResponse>(responseString);

                return comingSoonMoviesResponse;
            }
            return null;
        }


        public async Task<MovieInformationResponse> GetTitleAsync(string movieId)
        {
            var response = await _imdbApi.GetTitleAsync(movieId);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                var movieInformationResponse = _serializer.Deserialize<MovieInformationResponse>(responseString);

                return movieInformationResponse;
            }
            return null;
        }

        public async Task<TrailerResponse> GetTrailerAsync(string movieId)
        {
            var response = await _imdbApi.GetTrailerAsync(movieId);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                var trailerResponse = _serializer.Deserialize<TrailerResponse>(responseString);

                return trailerResponse;
            }
            return null;
        }


        IImdbApi _imdbApi;
        IJsonSerializerService _serializer;
    }
}
