using Api.Movie.Model;
using System.Text;

namespace Api.Movie.Extensions
{
    public static class MovieApiOptionsExtension
    {
        public static string GetDefaultUriWithParams(this MovieApiOptions options)
        {
            var builder = new StringBuilder();
            builder.Append(options.Uri);
            builder.Append("?");

            foreach (var key in options.Params.Keys)
                builder.Append($"{key}={options.Params[key]}&");

            return builder.ToString();
        }
    }
}
