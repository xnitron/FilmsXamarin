using System.Net.Http;
using FilmsXamarin.Model;
using Newtonsoft.Json;

namespace FilmsXamarin.ViewModel
{
    public class DetailFilmViewModel : BaseViewModel
    {
        private string Url = "https://api.themoviedb.org/3/movie/";
        private DetailFilmModel _detailFilm;
        private string _title;


        public DetailFilmViewModel(int id)
        {
            Url += id + "?api_key=c6237651419d439999a2de574022fd2f";

            GetJson();
        }

        public DetailFilmModel Detail
        {
            get
            {
                return _detailFilm;
            }
            set
            {
                if (value != _detailFilm)
                {
                    _detailFilm = value;

                    NotifyPropertyChanged();
                }
            }
        }

        public async void GetJson()
        {
            using (var _client = new HttpClient())
            {
                var content = await _client.GetStringAsync(Url);

                Detail = JsonConvert
                    .DeserializeObject<DetailFilmModel>(content);

                Title = Detail.Title;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value != _title)
                {
                    _title = value;

                    NotifyPropertyChanged();
                }
            }
        }
    }
}
