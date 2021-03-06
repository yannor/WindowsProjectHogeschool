﻿using Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Project.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BedrijfsPage : Page
    {
        public BedrijfsPage()
        {
            this.InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Disabled;

            ViewModel.Richting = DummyDataSource.RichtingBedrijfsManagement;
        }

        private void gaNaarAccountancy(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AccountancyFiscaliteit));
        }

        private void gaNaarFinance(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(FinancienVerzekeringen));
        }

        private void gaNaarKmo(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kmo));
        }

        private void gaNaarMarketing(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Marketing));
        }
    }
}
