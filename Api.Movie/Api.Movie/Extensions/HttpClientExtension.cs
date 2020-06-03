using Api.Movie.Model;
using System;
using System.Net.Http;

namespace Api.Movie.Extensions
{
    public static class HttpClientExtension
    {
        public static void ConfigureToIMDB(this HttpClient client, MovieApiOptions options)
        {
            client.BaseAddress = new Uri(options.BaseAddress);

            foreach (var key in options.Headers.Keys)
                client.DefaultRequestHeaders.Add(key, options.Headers[key]);
        }
    }
}
