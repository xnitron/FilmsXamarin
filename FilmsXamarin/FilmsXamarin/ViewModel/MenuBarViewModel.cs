﻿using FilmsXamarin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using FilmsXamarin.View;
using FilmsXamarin.ValueConvertes;
using Xamarin.Forms.PlatformConfiguration;
using System.Windows.Input;

namespace FilmsXamarin.ViewModel
{
    public class MenuBarViewModel : BaseViewModel
    {
        private ObservableCollection<MenuBarModel> _menuList;
        private MasterDetailPage _page;

        public ICommand ItemTappedCommand { get; protected set; }

        public MenuBarViewModel(MasterDetailPage page)
        {
            _page = page;

            MenuList = new ObservableCollection<MenuBarModel>
            {
                new MenuBarModel { Id = 0, MenuIcon = "about.png", MenuText="About" },
                new MenuBarModel { Id = 1, MenuIcon = "exit.png", MenuText = "Task View"},
            };

            ItemTappedCommand = new Command<object>(MenubarItem);
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

        private void MenubarItem(object arg)
        {
            if (arg != null && arg is ItemTappedEventArgs)
            {
                var menuBar = (arg as ItemTappedEventArgs).Item as MenuBarModel;

                switch (menuBar.Id)
                {
                    case 0:
                        _page.Detail.Navigation.PushAsync(new AboutView());
                        _page.IsPresented = false;
                        break;
                    case 1:
                        _page.Detail.Navigation.PushAsync(new TaskView());
                        _page.IsPresented = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
