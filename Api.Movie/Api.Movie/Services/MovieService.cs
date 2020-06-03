using Api.Movie.Interfaces;
using Api.Movie.Model;
using Api.Movie.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.Movie.Services
{
    public class MovieService : IMovieService
    {
        private readonly IIMDBProvider _iMDBProvider;
        private readonly string _filePath;

        public MovieService(IIMDBProvider iMDBProvider)
        {
            _iMDBProvider = iMDBProvider;
            _filePath = @$"{FileProvider.GetTempPath()}api_movie.json";
        }

        public IEnumerable<VideoElement> UpdateJsonFileWithValue(VideoElement video)
        {

            if (FileProvider.Exists(_filePath))
            {
                return UpdateFileOnTempDirectory(video);
            }
            else
            {
                var videos = new List<VideoElement> { video };

                CreateFileOnTempDirectory(videos);

                return videos;
            }
        }

        private IEnumerable<VideoElement> UpdateFileOnTempDirectory(VideoElement video)
        {
            var content = FileProvider.ReadAllText(_filePath);

            var videos = JsonConvert.DeserializeObject<List<VideoElement>>(content) ?? new List<VideoElement>();

            videos.Add(video);

            CreateFileOnTempDirectory(videos);

            return videos;
        }

        public IEnumerable<VideoElement> CreateJsonFileWithValues()
        {
            var response = _iMDBProvider.GetVideos().Result;

            CreateFileOnTempDirectory(response.Resource.Videos);

            return response.Resource.Videos;
        }

        private void CreateFileOnTempDirectory(IEnumerable<VideoElement> videos) => FileProvider.CreateFileOnTempDirectory(_filePath, videos);
    }
}
