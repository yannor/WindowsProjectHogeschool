using Project.Models;
using Project.Services.ProjectService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Windows.UI.Xaml.Navigation;

namespace Project.ViewModels
{
    public class ProjectViewModelBase : ViewModelBase
    {
        private Boolean _isLoggedIn;
        public Boolean IsLoggedIn
        {
            get { return _isLoggedIn; }
            set
            {

                _isLoggedIn = value;
                RaisePropertyChanged();
            }
        }

        private Gebruiker currentUser;
        public Gebruiker CurrentUser
        {
            get { return currentUser; }
            set
            {
                currentUser = value;
                RaisePropertyChanged();
            }
        }

        private Boolean _isInEditMode;
        public Boolean IsInEditMode
        {
            get { return _isInEditMode; }
            set
            {
                _isInEditMode = value;
                RaisePropertyChanged();
            }
        }

        public override Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            IsLoggedIn = ProjectService.Instance.IsLoggedIn;
            IsInEditMode = ProjectService.Instance.IsInEditMode;
            CurrentUser = ProjectService.Instance.CurrentUSer;

            return base.OnNavigatedToAsync(parameter, mode, state);
        }
    }
}
