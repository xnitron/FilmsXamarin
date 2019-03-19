using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmsXamarin.ViewModel;
using FilmsXamarin.Model;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FilmsXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailFilmView : ContentPage
    {
        public DetailFilmView(int id)
        {
            InitializeComponent();
            BindingContext = new DetailFilmViewModel(id);
        }
    }
}