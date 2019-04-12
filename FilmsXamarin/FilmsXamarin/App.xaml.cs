using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FilmsXamarin.View;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FilmsXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}
