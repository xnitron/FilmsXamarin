using FilmsXamarin.ViewModel;
using Xamarin.Forms;
using Plugin.Fingerprint;

namespace FilmsXamarin.View
{
    public partial class MainPage : MasterDetailPage
    {
        private const string _password = "123";

        public MainPage()
        {
            InitializeComponent();

            AuthenticateWithFingerPrint();
        }

        private async void AuthenticateWithFingerPrint()
        {
            var authResult = await CrossFingerprint.Current.AuthenticateAsync("Put your finger");

            if (authResult.Authenticated)
            {
                OnAuthSuccess();
            }
        }

        private void OnAuthButtonClick(object sender, System.EventArgs e)
        {
            if (PasswordField.Text == _password)
            {
                OnAuthSuccess();
            }
            else
            {
                DisplayAlert("Error", "Authentication error", "Ok");
            }
        }

        private void OnAuthFingerButtonClick(object sender, System.EventArgs e)
        {
            AuthenticateWithFingerPrint();
        }

        private void OnAuthSuccess()
        {
            Detail = new NavigationPage(new FilmsView());
            BindingContext = new MenuBarViewModel(this);
        }
    }
}
