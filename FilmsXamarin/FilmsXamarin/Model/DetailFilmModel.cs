using Newtonsoft.Json;

namespace FilmsXamarin.Model
{
    public class DetailFilmModel : FilmModel
    {
        [JsonProperty("original_language")]
        public string Language { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }
        
        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("budget")]
        public int Budget { get; set; }

        [JsonProperty("runtime")]
        public int Duration { get; set; }

    }
}
