using System;
using Project.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Services.Maps;
using Windows.UI;
using Windows.UI.Xaml.Controls.Maps;
using Template10.Services.NavigationService;
using Windows.ApplicationModel.Appointments;
using Windows.UI.Xaml.Media;
using Project.Models;

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

        //opendeurdag toevoegen aan kalender als evenement
        public static Rect GetElementRect(FrameworkElement element)
        {
            GeneralTransform buttonTransform = element.TransformToVisual(null);
            Point point = buttonTransform.TransformPoint(new Point());
            return new Rect(point, new Size(element.ActualWidth, element.ActualHeight));
        }
        private async void AddEvent()
        {
            var appointment = new Appointment();
            appointment.Subject = "Opendeurdag HoGent";
            appointment.Details = "Wilt u graag wat meer informatie? Kom gerust eens langs op onze opendeurdag op campus Aalst.";
            appointment.Location = "HoGent Campus Aalst, Arbeidstraat 14";
            appointment.StartTime = new DateTime(2017, 4, 22, 10,00,00);
            appointment.Duration = TimeSpan.FromHours(7);
            var rect = MainPage.GetElementRect(this as FrameworkElement);
            String appointmentId = await AppointmentManager.ShowAddAppointmentAsync(appointment, rect, Windows.UI.Popups.Placement.Default);
        }

        public async void showPointOnMap()
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
            await MyMap.TrySetViewAsync(gp2);

        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowRouteOnMap();
        }

        private async void ShowRouteOnMap()
        {
            // Request permission to access location
            var accessStatus = await Geolocator.RequestAccessAsync();

            switch (accessStatus)
            {
                case GeolocationAccessStatus.Allowed:
                    // If DesiredAccuracy or DesiredAccuracyInMeters are not set (or value is 0), DesiredAccuracy.Default is used.
                    Geolocator geolocator = new Geolocator { DesiredAccuracyInMeters = 100 };

                    // Carry out the operation
                    Geoposition startPosition = await geolocator.GetGeopositionAsync().AsTask();
                    BasicGeoposition endLocation = new BasicGeoposition() { Latitude = 50.937000, Longitude = 4.033180 };
                    BasicGeoposition gep = new BasicGeoposition();
                    gep.Latitude = startPosition.Coordinate.Latitude;
                    gep.Longitude = startPosition.Coordinate.Longitude;
                    Geopoint gp1 = new Geopoint(gep);
                    Geopoint gp2 = new Geopoint(endLocation);
                   
                    // Get the route between the points.
                    MapRouteFinderResult routeResult =
                          await MapRouteFinder.GetDrivingRouteAsync(
                          gp1,
                          gp2,
                          MapRouteOptimization.Time,
                          MapRouteRestrictions.None);

                    // Create a MapIcon.
                    MapIcon mapIcon1 = new MapIcon();
                    mapIcon1.Location = gp1;
                    mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
                    mapIcon1.Title = "Uw locatie";
                    mapIcon1.ZIndex = 0;
                    // Add the MapIcon to the map.
                    MyMap.MapElements.Add(mapIcon1);

                    MapIcon mapIcon2 = new MapIcon();
                    mapIcon2.Location = gp2;
                    mapIcon2.NormalizedAnchorPoint = new Point(0.5, 1.0);
                    mapIcon2.Title = "Hogent Campus Aalst Arbeidstraat 14";
                    mapIcon2.ZIndex = 0;
                    MyMap.MapElements.Add(mapIcon2);

                    if (routeResult.Status == MapRouteFinderStatus.Success)
                    {
                        // Use the route to initialize a MapRouteView.
                        MapRouteView viewOfRoute = new MapRouteView(routeResult.Route);
                        viewOfRoute.RouteColor = Colors.Yellow;
                        viewOfRoute.OutlineColor = Colors.Black;

                        // Add the new MapRouteView to the Routes collection
                        // of the MapControl.
                        MyMap.Routes.Add(viewOfRoute);

                        // Fit the MapControl to the route.
                        await MyMap.TrySetViewBoundsAsync(
                              routeResult.Route.BoundingBox,
                              null,
                              Windows.UI.Xaml.Controls.Maps.MapAnimationKind.None);
                    }

                    break;
                    case GeolocationAccessStatus.Denied:
                    //              
                    break;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddEvent();
        }
    }
}
