using FilmsXamarin.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FilmsXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmsView : ContentPage
    {
        public FilmsView()
        {
            InitializeComponent();

            BindingContext = new FilmsViewModel(this);
        }
    }
}