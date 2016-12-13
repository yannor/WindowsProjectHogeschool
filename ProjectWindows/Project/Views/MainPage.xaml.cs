using System;
using Project.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.UI.Xaml.Controls.Maps;
using Template10.Services.NavigationService;

namespace Project.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            showPointOnMap();
        }

        public void showPointOnMap()
        {
            //50,937000, 4,033180
            BasicGeoposition endLocation = new BasicGeoposition() { Latitude = 50.937000, Longitude = 4.033180 };
            
            Geopoint gp2 = new Geopoint(endLocation);

            MapIcon mapIcon2 = new MapIcon();
            mapIcon2.Location = gp2;
            mapIcon2.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon2.Title = "Hogent Campus Aalst";
            mapIcon2.ZIndex = 0;
            MyMap.MapElements.Add(mapIcon2);


        }

        private void informatica_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bedrijfsmanagement_Click(object sender, RoutedEventArgs e)
        {

        }

        private void officemanagement_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
