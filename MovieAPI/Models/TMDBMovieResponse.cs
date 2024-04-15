using Newtonsoft.Json;

namespace MovieAPI.Models
{
    public class TMDBMovieResponse
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("results")]
        public List<TMDBMovieInformation> Results { get; set; }

        [JsonProperty("total_pages")]
        public double TotalPages { get; set; }

        [JsonProperty("total_results")]
        public double TotalResults { get; set; }

       

    }
}
