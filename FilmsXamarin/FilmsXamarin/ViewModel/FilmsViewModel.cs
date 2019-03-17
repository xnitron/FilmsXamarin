using FilmsXamarin.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using FilmsXamarin.View;
using Xamarin.Forms;
using System.Reflection;
using System.Net.Http;

namespace FilmsXamarin.ViewModel
{
    public class FilmsViewModel : BaseViewModel
    {
        private FilmModel _filmModel;
        private const string Url = "https://api.themoviedb.org/3/discover/movie?sort_by=popularity.desc&api_key=c6237651419d439999a2de574022fd2f";
        private HttpClient _client = new HttpClient();
        private List<FilmModel> json { get; set; }
        private Page _page;
        private ObservableCollection<FilmModel> _films;

        public FilmsViewModel()
        {
            

            //json = json.Select(film =>
            //{
            //    film.OverView = TrimString(film.OverView);

            //    film.DisplayImage = @"/Images" + film.DisplayImage;
            //    return film;
            //});

            GetJson();

        }

        public async void GetJson()
        {
            var content = await _client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<FilmModelList>(content);
            json = posts.results;
            
            var post = json.Select(film =>
                {
                    film.overview = TrimString(film.overview);

                    film.poster_path = @"/Images" + film.poster_path;
                    return film;
                });

            Films = new ObservableCollection<FilmModel>(post);
        }

        public FilmModel Film
        {
            get
            {
                return _filmModel;
            }
            set
            {
                if (value != _filmModel)
                {
                    _filmModel = value;
                    _page = new NavigationPage(new SelectedFilm());
                    NotifyPropertyChanged();
                }
            }
        }

        //public ObservableCollection<FilmModelList> Films { get; set; }
        //public ObservableCollection<FilmModel> Films { get; set; }
        public ObservableCollection<FilmModel> Films
        {
            get
            {
                return _films;
            }
            set
            {

                _films = value;
                NotifyPropertyChanged();

            }
        }

        private string TrimString(string str, int length = 100)
        {
            if (str.Length > length)
            {
                return str.Substring(0, length) + " ...";
            }
            return str;
        }
    }

}
