using FilmsXamarin.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FilmsXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailFilmView : ContentPage
    {
        public DetailFilmView(int id)
        {
            InitializeComponent();

            BindingContext = new DetailFilmViewModel(id);
        }
    }
}