using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FilmsXamarin.Model;
using FilmsXamarin.ViewModel;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FilmsXamarin.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FilmsView : ContentPage
	{
		public FilmsView ()
		{
            try
            {

			InitializeComponent ();
            BindingContext = new FilmsViewModel();
            }
            catch (Exception ex)
            {

                throw ex ;
            }
		}

        //private const string Url = "https://api.themoviedb.org/3/discover/movie?sort_by=popularity.desc&api_key=c6237651419d439999a2de574022fd2f";
        //private HttpClient _client = new HttpClient();
        //ObservableCollection<FilmModel> vrex;
        //protected override async void OnAppearing()
        //{
        //    var content = await _client.GetStringAsync(Url);
        //    var posts = JsonConvert.DeserializeObject<FilmModelList>(content);

        //     //vrex = new ObservableCollection<FilmModel>(posts.results);
        //    FilmsList.ItemsSource = posts.results;
        //    base.OnAppearing();
        //}

    }
}