using Newtonsoft.Json;

namespace MovieAPI.Models
{
    public class TMDBMovieInformation
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("original_language")]
        public string Language { get; set; }

        [JsonProperty("original_title")]
        public string OrginalTitle { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set;}

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public double VoteCount { get; set; }


    }
}
