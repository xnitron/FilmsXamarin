using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FilmsXamarin.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FilmsView : ContentPage
	{
		public FilmsView ()
		{
			InitializeComponent ();
		}
	}
}