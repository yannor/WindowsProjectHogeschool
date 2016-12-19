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

namespace Project.ViewModels
{
    public class LoginPageViewModel : ProjectViewModelBase
    {
        public LoginPageViewModel()
        {
            //IsLoggedIn = true;
            // _richting = new Richting() { Description="", Html="http://google.com", Title=""};
        }
        
        public bool Register(Gebruiker g)
        {
            foreach(Gebruiker i in DummyDataSource.Admins)
            {
                if (i.Gebruikersnaam == g.Gebruikersnaam)
                    return false;
            }

            DummyDataSource.Admins.Add(g);

            return true;
        }

        public bool Login(String username, String password)
        {
            //List<Gebruiker> admins = Backend.GetGebruikers().Result;

            foreach (Gebruiker g in DummyDataSource.Admins)
            {
                if (g.Gebruikersnaam == username && g.Wachtwoord == g.Wachtwoord)
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
