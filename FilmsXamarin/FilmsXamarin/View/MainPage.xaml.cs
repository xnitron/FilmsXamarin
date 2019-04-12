using FilmsXamarin.ViewModel;
using Xamarin.Forms;

namespace FilmsXamarin.View
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new FilmsView());
            BindingContext = new MenuBarViewModel(this); 
        }
        
    }
}
