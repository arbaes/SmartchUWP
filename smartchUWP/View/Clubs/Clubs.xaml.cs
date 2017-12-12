﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace smartchUWP.View.Clubs
{
    public sealed partial class Clubs : Page
    {
        public Clubs()
        {
            this.InitializeComponent();
        }

        private void AddClub_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddClub));
        }
        
    }
}
