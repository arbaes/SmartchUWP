﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace smartchUWP.View.Membres
{
    public sealed partial class Membres : Page
    {
        public Membres()
        {
            this.InitializeComponent();
        }
        private void AddMembre_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddMembre));
        }
    }
}