using System;
using System.Collections.Generic;
using System.Text;

namespace MuviApp
{
    public static class ApiConfig
    {
        public const string BaseAdress = "https://imdb-api.com";

        public const string MostPopularMovies = "/en/API/MostPopularMovies/k_w1pp3vl1";

        public const string ComingSoon = "/en/API/ComingSoon/k_w1pp3vl1";

        public const string Title = "/en/API/Title/k_w1pp3vl1/{movieId}";

        public const string Trailer = "/en/API/Trailer/k_w1pp3vl1/{movieId}";

        public const string Actor = "/en/API/Name/k_w1pp3vl1/{actorId}";



    }
}
