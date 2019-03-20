using FilmsXamarin.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using FilmsXamarin.View;
using FilmsXamarin.ValueConvertes;
using Xamarin.Forms;
using FilmsXamarin.Utils;
using System.Net.Http;
using System.Windows.Input;

namespace FilmsXamarin.ViewModel
{

    public class FilmsViewModel : BaseViewModel
    {
        private const string Url = "https://api.themoviedb.org/3/discover/movie?sort_by=popularity.desc&api_key=c6237651419d439999a2de574022fd2f";
        private Page _page;
        private ObservableCollection<FilmModel> _films;

        public ICommand ItemTappedCommand { get; protected set; }

        public FilmsViewModel(Page page)
        {
            _page = page;
            GetJson();
            ItemTappedCommand = new Command((object arg) =>
            {
                if (arg != null && arg is ItemTappedEventArgs)
                {
                    var film = (arg as ItemTappedEventArgs).Item as FilmModel;
                    _page.Navigation.PushAsync(new DetailFilmView(film.id));
                }
            });
        }

        public async void GetJson()
        {
            using (var _client = new HttpClient())
            {
                var content = await _client.GetStringAsync(Url);
                var post = JsonConvert
                    .DeserializeObject<FilmModelList>(content).results
                    .Select(film =>
                    {
                        film.OverView = StringUtils.TrimString(film.OverView);

                        return film;
                    });
                Films = new ObservableCollection<FilmModel>(post);
            }
        }

        public ObservableCollection<FilmModel> Films
        {
            get
            {
                return _films;
            }
            set
            {
                if (value != _films)
                {
                    _films = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
