using Api.Movie.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Movie.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<VideoElement> CreateJsonFileWithValues();
        IEnumerable<VideoElement> UpdateJsonFileWithValue(VideoElement video);
    }
}
