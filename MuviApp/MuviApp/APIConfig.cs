using System;
using System.Collections.Generic;
using System.Text;

namespace MuviApp
{
    public static class ApiConfig
    {
        public const string BaseAdress = "https://imdb-api.com";

        public const string ApiKey = "PASTE_YOUR_API_KEY_HERE";

        public const string MostPopularMovies = "/en/API/MostPopularMovies/PASTE_YOUR_API_KEY_HERE";

        public const string ComingSoon = "/en/API/ComingSoon/PASTE_YOUR_API_KEY_HERE";

        public const string Title = "/en/API/Title/PASTE_YOUR_API_KEY_HERE/{movieId}";

        public const string Trailer = "/en/API/Trailer/PASTE_YOUR_API_KEY_HERE/{movieId}";

        public const string Actor = "/en/API/Name/PASTE_YOUR_API_KEY_HERE/{actorId}";



    }
}
