using Newtonsoft.Json;

namespace Api.Movie.Model
{
    public class VideoElement
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("primaryTitle")]
        public PrimaryTitle PrimaryTitle { get; set; }
    }

    public class PrimaryTitle
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }
}
