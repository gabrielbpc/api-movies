using System.Collections.Generic;

namespace Api.Movie.Model
{
    public class MovieApiOptions
    {
        public string BaseAddress { get; set; }
        public string Uri { get; set; }
        public Dictionary<string, string> Params { get; set; }
        public Dictionary<string, string> Headers { get; set; }
    }
}
