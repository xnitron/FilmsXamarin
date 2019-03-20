using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmsXamarin.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FilmsXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskView : ContentPage
    {
        public TaskView()
        {
            InitializeComponent();

            BindingContext = new TaskViewModel(this);
        }

        private double _width, _height;
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width != _width || height != _height)
            {
                _width = width;
                _height = height;

                if (width > height)
                {
                    MainStack.Orientation = StackOrientation.Horizontal;
                    StackEntry.Orientation = StackOrientation.Vertical;
                    EntryNumber.HorizontalOptions = LayoutOptions.FillAndExpand;
                }
                else
                {
                    MainStack.Orientation = StackOrientation.Vertical;
                    StackEntry.Orientation = StackOrientation.Horizontal;
                }
            }

        }
    }
}