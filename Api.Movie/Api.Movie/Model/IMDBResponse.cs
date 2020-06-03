using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.Movie.Model
{

    public class IMDBResponse
    {
        [JsonProperty("resource")]
        public Resource Resource { get; set; }
    }

    public class Resource
    {
        [JsonProperty("videos")]
        public IEnumerable<VideoElement> Videos { get; set; }
    }
}

