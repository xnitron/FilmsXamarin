using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
