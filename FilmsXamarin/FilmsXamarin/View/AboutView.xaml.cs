using FilmsXamarin.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FilmsXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutView : ContentPage
    {
        public AboutView()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel();
        }    
    }
}