using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FilmsXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutView : ContentPage
    {
        private double _width = 0, _height = 0;

        protected enum OrientationValue
        {
            Portrait,
            Landscape
        }

        public AboutView()
        {
            InitializeComponent();
        }
        
        

        protected virtual void OnOrientationChanged(OrientationValue newOrientation) { }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            
            if(width > height)
            {
                DisplayAlert("saf", "asdf", "sadf");
            }
        }
    
    }
}