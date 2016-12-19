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

namespace Project.ViewModels
{
    public class MainPageViewModel : ProjectViewModelBase
    {
        private Campus _campus;
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

