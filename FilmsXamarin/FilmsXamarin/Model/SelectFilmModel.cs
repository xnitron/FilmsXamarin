using Newtonsoft.Json;

namespace FilmsXamarin.Model
{
    public class SelectFilmModel : FilmModel
    {
        [JsonProperty("original_language")]
        public string Language { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }
        
        [JsonProperty("popularity")]
        public double Popularity { get; set; }

    }
}
