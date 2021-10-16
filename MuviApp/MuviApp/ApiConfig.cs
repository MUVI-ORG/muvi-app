using System;
using System.Collections.Generic;
using System.Text;

namespace MuviApp
{
    public static class ApiConfig
    {
        public const string BaseAdress = "https://imdb-api.com";

        //public const string ApiKey = "k_6xveuhnv";

        public const string MostPopularMovies = "/en/API/MostPopularMovies/k_6xveuhnv";

        public const string ComingSoon = "/en/API/ComingSoon/k_6xveuhnv";

        public const string Title = "/en/API/Title/k_6xveuhnv/{movieId}";

        public const string Trailer = "/en/API/Trailer/k_6xveuhnv/{movieId}";

        public const string Actor = "/en/API/Name/k_6xveuhnv/{actorId}";



    }
}
