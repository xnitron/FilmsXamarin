using FilmsXamarin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using FilmsXamarin.View;

namespace FilmsXamarin.ViewModel
{
    public class MenuBarViewModel : BaseViewModel
    {
        private ObservableCollection<MenuBarModel> _menuList;
        private MenuBarModel _menuBar;
        MasterDetailPage _page;

        public MenuBarViewModel(MasterDetailPage page)
        {
            _page = page;

            MenuList = new ObservableCollection<MenuBarModel>
            {
                new MenuBarModel { Id = 0, MenuIcon = "about.png", MenuText="About" },
                new MenuBarModel { Id = 1, MenuIcon = "exit.png", MenuText = "Exit"},
                new MenuBarModel { Id = 2, MenuIcon = "exit.png", MenuText = "Task View"},
            };
        }

        public ObservableCollection<MenuBarModel> MenuList
        {
            get
            {
                return _menuList;
            }
            set
            {
                if (value != _menuList)
                {
                    _menuList = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public MenuBarModel SelectedMenuItem
        {
            get
            {
                return _menuBar;
            }
            set
            {
                if (value != _menuBar)
                {
                    _menuBar = value;
                    
                    switch (_menuBar.Id)
                    {
                        case 0:
                            _page.Detail = new NavigationPage(new AboutView());
                            _page.IsPresented = false;
                            break;
                        case 2:
                            _page.Detail = new NavigationPage(new TaskView());
                            _page.IsPresented = false;
                            break;
                        default:
                            break;
                    }
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
