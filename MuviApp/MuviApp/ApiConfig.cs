using System;
using System.Collections.Generic;
using System.Text;

namespace MuviApp
{
    public static class ApiConfig
    {
        public const string BaseAdress = "https://imdb-api.com";

        //public const string ApiKey = "k_lr7ijm2d";

        public const string MostPopularMovies = "/en/API/MostPopularMovies/k_lr7ijm2d";

        public const string ComingSoon = "/en/API/ComingSoon/k_lr7ijm2d";

        public const string Title = "/en/API/Title/k_lr7ijm2d/{movieId}";

        public const string Trailer = "/en/API/Trailer/k_lr7ijm2d/{movieId}";

        public const string Actor = "/en/API/Name/k_lr7ijm2d/{actorId}";



    }
}
