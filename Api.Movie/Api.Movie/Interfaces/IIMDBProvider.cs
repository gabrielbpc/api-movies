using Api.Movie.Model;
using System.Threading.Tasks;

namespace Api.Movie.Interfaces
{
    public interface IIMDBProvider
    {
        Task<IMDBResponse> GetVideos();
    }
}
