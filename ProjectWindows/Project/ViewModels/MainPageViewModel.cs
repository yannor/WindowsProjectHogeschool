using Template10.Mvvm;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using Project.Models;
using System.Collections.ObjectModel;
using Project.Services.ProjectService;
using System.Net.Http;
using Newtonsoft.Json;

namespace Project.ViewModels
{
    public class MainPageViewModel : ProjectViewModelBase
    {
        private Campus _campus;
        ObservableCollection<Evenement> evs = new ObservableCollection<Evenement>();
        public Campus Campus
        {
            get { return _campus; }
            set
            {
                if (value == null)
                    return;

                _campus = value;
                RaisePropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            
           
        }

        public async Task<ObservableCollection<Evenement>> getEvents()
        {
            HttpClient client = new HttpClient();
            var jsonString = await client.GetStringAsync(new Uri("http://localhost:23938/api/evenementen"));
            evs = JsonConvert.DeserializeObject<ObservableCollection<Evenement>>(jsonString);
            return evs;
        }

        public async void deleteEvent(Evenement e)
        {
            var jsonString = JsonConvert.SerializeObject(e);
            HttpClient client = new HttpClient();
           
            var response = await client.DeleteAsync("http://localhost:23938/api/evenementen/" + e.EvenementID);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                evs.Remove(e);
            }
        }

        public async void addEvent(Evenement e)
        {
            evs.Add(e);            
            var jsonString = JsonConvert.SerializeObject(e);
            HttpClient client = new HttpClient();
            var res = await client.PostAsync("http://localhost:23938/api/evenementen", new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json"));
        }



        private DelegateCommand _saveCommand;
        public DelegateCommand SaveCommand => _saveCommand ?? (_saveCommand = new DelegateCommand(() => {
            SaveRichting();
        }));

        private DelegateCommand _editCommand;
        public DelegateCommand EditCommand => _editCommand ?? (_editCommand = new DelegateCommand(() => {
            SetEditMode(!ProjectService.Instance.IsInEditMode);
        }));

        private void SetEditMode(bool val)
        {
            IsInEditMode = val;
            ProjectService.Instance.IsInEditMode = val;
        }

        public void SaveRichting()
        {
            //TODO: save de richting met de API
            SetEditMode(false);
            RaisePropertyChanged("Campus");

        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }
        
        public void GotoSettings() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 0);

        public void GotoPrivacy() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 1);

        public void GotoAbout() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 2);

    }
}

