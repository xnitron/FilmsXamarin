using FilmsXamarin.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Linq;
using FilmsXamarin.View;
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
        private bool _indicator = true;
        private ObservableCollection<FilmModel> _films;

        public ICommand ItemTappedCommand { get; protected set; }

        public FilmsViewModel(Page page)
        {
            _page = page;

            SetFilms();

            ItemTappedCommand = new Command((object arg) =>
            {
                if (arg != null && arg is ItemTappedEventArgs)
                {
                    var film = (arg as ItemTappedEventArgs).Item as FilmModel;

                    _page.Navigation.PushAsync(new DetailFilmView(film.id));
                }
            });
        }

        public async void SetFilms()
        {
            using (var _client = new HttpClient())
            {
                var content = await _client.GetStringAsync(Url);

                var filmsData = JsonConvert
                    .DeserializeObject<FilmModelList>(content).results
                    .Select(film =>
                    {
                        film.OverView = StringUtils.TrimString(film.OverView);

                        return film;
                    });

                Films = new ObservableCollection<FilmModel>(filmsData);

                Indicator = false;
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

        public bool Indicator
        {
            get
            {
                return _indicator;   
            }
            set
            {
                if (value != _indicator)
                {
                    _indicator = value;

                    NotifyPropertyChanged();
                }
            }
        }
    }
}
