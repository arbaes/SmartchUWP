﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace smartchUWP.ViewModel
{
    public class MainPageViewModel : ViewModelBase
    {
        private Boolean _isChargement = false;

        public Boolean IsChargement
        {
            get
            {
                return _isChargement;
            }
            set
            {
                _isChargement = value;
                RaisePropertyChanged("IsChargement");
                RaisePropertyChanged("IsNotChargement");
            }
        }
        public Boolean IsNotChargement
        {
            get
            {
                return !IsChargement;
            }
            set
            {
                IsChargement = value;
            }
        }

        public RelayCommand<Object> CommandSelectChangeMenu { get; private set; }
        public RelayCommand<Object> CommandInvokedMenu { get; private set; }
        protected readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            CommandSelectChangeMenu = new RelayCommand<Object>(SelectionChanged );
            CommandInvokedMenu = new RelayCommand<Object>(InvokedItemMenu);

            
        }
        
        
        public void SelectionChanged(Object args)
        {
            NavigationViewSelectionChangedEventArgs navigationItem = (NavigationViewSelectionChangedEventArgs)args;
             if (navigationItem.IsSettingsSelected)
            {
               _navigationService.NavigateTo("Login");
            }
            else
            {

                NavigationViewItem item = navigationItem.SelectedItem as NavigationViewItem;
                SwitchItemNavigation(item);
                
            }
        }

        private void InvokedItemMenu(Object args)
        {
            NavigationViewItemInvokedEventArgs navigationItem = (NavigationViewItemInvokedEventArgs)args;
            if (navigationItem.IsSettingsInvoked)
            {
                _navigationService.NavigateTo("Login");
            }
            else
            {
                NavigationViewItem item = navigationItem.InvokedItem as NavigationViewItem;
                SwitchItemNavigation(item);
            }
        }
        private void SwitchItemNavigation(NavigationViewItem item) {
            if(item != null)
            switch (item.Tag)
            {
                case "home":
                    _navigationService.NavigateTo("Login");
                    break;

                case "members":
                    _navigationService.NavigateTo("Membres");
                    break;

                case "clubs":
                    _navigationService.NavigateTo("Clubs");
                    break;

                case "spectators":
                    _navigationService.NavigateTo("Login");
                    break;

                case "tournaments":
                    _navigationService.NavigateTo("Tournaments");
                    break;
            }
        }

        public void SwitchError(Error error)
        {

        }
    }
}
