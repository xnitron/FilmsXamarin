using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using FilmsXamarin.Model;
using Newtonsoft.Json;

namespace FilmsXamarin.ViewModel
{
    public class DetailFilmViewModel : BaseViewModel
    {
        private string Url = "https://api.themoviedb.org/3/movie/";
        private DetailFilmModel _detailFilm;

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

        public DetailFilmViewModel(int id)
        {
            Url += id + "?api_key=c6237651419d439999a2de574022fd2f";
            GetJson();
        }


        public async void GetJson()
        {
            var _client = new HttpClient();
            var content = await _client.GetStringAsync(Url);

            Detail = JsonConvert
                .DeserializeObject<DetailFilmModel>(content);
            NameTitle = Detail.Title;
        }

        private string _nameTitle;
        public string NameTitle
        {
            get
            {
                return _nameTitle;
            }
            set
            {
                if (value != _nameTitle)
                {
                    _nameTitle = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }
}
