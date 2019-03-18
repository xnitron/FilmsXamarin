using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FilmsXamarin.Model
{
    public class FilmModel
    {
        public int id { get; set; }
        public string poster_path { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("vote_average")]
        public double Vote { get; set; }
        [JsonProperty("overview")]
        public string OverView { get; set; }
        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }
    }

    public class FilmModelList
    {

        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public List<FilmModel> results { get; set; }
    }
}
