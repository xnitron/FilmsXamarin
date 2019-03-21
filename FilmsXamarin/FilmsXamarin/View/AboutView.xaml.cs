using FilmsXamarin.ViewModel;
using System.Threading.Tasks;
using Plugin.Compass;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Sensors;


namespace FilmsXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutView : ContentPage
    {

        public AboutView()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel();

            CrossCompass.Current.CompassChanged += (s, e) =>
            {
                if(e.Heading > 50 & e.Heading < 300)
                    mainText.FontSize = e.Heading / 10;
            };
            CrossCompass.Current.Start();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(1000);

            await Task.WhenAll(
                SplashGrid.FadeTo(0, 2000),
                Logo.ScaleTo(10, 2000)
                );
            outerStack.IsVisible = true;
        }
    }
}