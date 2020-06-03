using Api.Movie.Extensions;
using Api.Movie.Interfaces;
using Api.Movie.Model;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.Movie.Providers
{
    public class IMDBProvider : IIMDBProvider
    {
        private readonly HttpClient _httpClient;
        private readonly MovieApiOptions _options;

        public IMDBProvider(IHttpClientFactory httpClientFactory, IOptions<MovieApiOptions> options)
        {
            _httpClient = httpClientFactory.CreateClient();
            _options = options.Value;
            ConfigureToIMDB();
        }

        private void ConfigureToIMDB() => _httpClient.ConfigureToIMDB(_options);

        public async Task<IMDBResponse> GetVideos()
        {
            var response = await _httpClient.GetAsync(_options.GetDefaultUriWithParams());
            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IMDBResponse>(result);
        }
    }
}
