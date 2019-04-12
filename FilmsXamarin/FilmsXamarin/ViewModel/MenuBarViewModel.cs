using FilmsXamarin.Model;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using FilmsXamarin.View;
using System.Windows.Input;

namespace FilmsXamarin.ViewModel
{
    public class MenuBarViewModel : BaseViewModel
    {
        private MasterDetailPage _page;

        public ObservableCollection<MenuBarModel> MenuList { get; set; }
        public ICommand ItemTappedCommand { get; protected set; }

        public MenuBarViewModel(MasterDetailPage page)
        {
            _page = page;

            MenuList = new ObservableCollection<MenuBarModel>
            {
                new MenuBarModel { Id = 0, MenuIcon = "about.png", MenuText = "About" },
                new MenuBarModel { Id = 1, MenuIcon = "exit.png", MenuText = "Task View"},
            };

            ItemTappedCommand = new Command<object>(Navigate);
        }

        private void Navigate(object arg)
        {
            if (arg != null && arg is ItemTappedEventArgs)
            {
                var menuBar = (arg as ItemTappedEventArgs).Item as MenuBarModel;

                switch (menuBar.Id)
                {
                    case 0:
                        _page.Detail.Navigation.PushAsync(new AboutView());
                        break;
                    case 1:
                        _page.Detail.Navigation.PushAsync(new TaskView());
                        break;
                    default:
                        break;
                }

                _page.IsPresented = false;
            }
        }
    }
}
