using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FilmsXamarin.View
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new FilmsView());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SelectedFilm());
            IsPresented = false;
        }
    }
}
