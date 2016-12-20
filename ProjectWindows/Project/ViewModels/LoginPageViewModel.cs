using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Navigation;
using Project.Models;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Project.Services.ProjectService;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Project.ViewModels
{
    public class LoginPageViewModel : ProjectViewModelBase
    {

        ObservableCollection<Gebruiker> gs = new ObservableCollection<Gebruiker>();

        public LoginPageViewModel()
        {
            //IsLoggedIn = true;
            // _richting = new Richting() { Description="", Html="http://google.com", Title=""};
        }


        public async Task<bool> Login(String username, String password)
        {
            //List<Gebruiker> admins = Backend.GetGebruikers().Result;

            HttpClient client = new HttpClient();
            var jsonString = await client.GetStringAsync(new Uri("http://localhost:23938/api/gebruikers"));
            gs = JsonConvert.DeserializeObject<ObservableCollection<Gebruiker>>(jsonString);

            bool x = false;


            foreach (Gebruiker g in gs)
            {
                if (g.Gebruikersnaam.Equals(username) && g.Wachtwoord.Equals(password))
                {
                    ProjectService.Instance.CurrentUSer = g;
                    ProjectService.Instance.IsLoggedIn = true;
                    IsLoggedIn = true;
                    return true;

                }
            }



            return false;
        }

        public void Logout()
        {
            ProjectService.Instance.IsLoggedIn = false;
            ProjectService.Instance.IsInEditMode = false;
            IsLoggedIn = false;
        }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            //Views.Busy.SetBusy(true, "Laden");
            //await Task.Delay(500);
            //Views.Busy.SetBusy(false);
            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
            {

            }
            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

    }
}
