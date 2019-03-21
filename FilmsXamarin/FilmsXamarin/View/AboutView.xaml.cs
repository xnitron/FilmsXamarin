using FilmsXamarin.ViewModel;
using System.Threading.Tasks;
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

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(1000);

            // Start animation
            await Task.WhenAll(
                SplashGrid.FadeTo(0, 2000),
                Logo.ScaleTo(10, 2000)
                );
            outerStack.IsVisible = true;
        }
    }
}