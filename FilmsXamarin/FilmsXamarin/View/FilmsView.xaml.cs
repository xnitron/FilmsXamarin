using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FilmsXamarin.Model;
using FilmsXamarin.ViewModel;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FilmsXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmsView : ContentPage
    {
        public FilmsView()
        {
            InitializeComponent();
            BindingContext = new FilmsViewModel(this);
            
        }


    }
}