using FilmsXamarin.ViewModel;
using Xamarin.Forms;
using Plugin.Fingerprint;

namespace FilmsXamarin.View
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Authenticate();
        }

        private async void Authenticate()
        {
            var authResult = await CrossFingerprint.Current.AuthenticateAsync("Put your finger");

            if (authResult.Authenticated)
            {
                Detail = new NavigationPage(new FilmsView());
                BindingContext = new MenuBarViewModel(this);
            }
        }
    }
}
