using Newtonsoft.Json;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Popups;
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
    public sealed partial class LoginPage : Page
    {
        

        public LoginPage()
        {
            this.InitializeComponent();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            String password = txtPassword.Password;
            String username = txtUsername.Text;

   
            bool x= await viewmodel.Login(username, password);

 
            MessageDialog md = new MessageDialog(x ? "Succesvol ingelogd" : "Foutieve gebruikersnaam of wachtwoord", "Login");
            await md.ShowAsync();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewmodel.Logout();
        }

        private void SendNotification(object s, RoutedEventArgs e)
        {
            String msg = txtInput.Text;
            String xml = "<toast launch=\"app-defined-string\">"
                + "<visual>"
                + "<binding template=\"ToastGeneric\">"
                + "<text>HoGent Campus Aalst</text>"
                + "<text>" + msg + "</text>"
                + "<image src = \"https://www.hogent.be/www/assets/Image/campusAalstCoverBuiten.jpg \" />"
                + "<image placement=\"appLogoOverride\" src=\"https://www.hogent.be/www/assets/Image/campusAalstCoverBuiten.jpg \" hint-crop=\"circle\" />"
                + "</binding>"
                + "</visual>"
                + "</toast> ";

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);

            ToastNotification notification = new ToastNotification(xmlDoc);
            ToastNotificationManager.CreateToastNotifier().Show(notification);
        }
    }
}
