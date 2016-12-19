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
    public class RichtingViewModel : ProjectViewModelBase
    {
        

        public RichtingViewModel()
        {
           // _richting = new Richting() { Description="", Html="http://google.com", Title=""};
        }

        private Richting _richting; 
        public Richting Richting {
            get { return _richting; }
            set
            {
                if (value == null)
                    return;
                _richting = value;
                RaisePropertyChanged();
            }
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
            RaisePropertyChanged("Richting");
            
        }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            await base.OnNavigatedToAsync(parameter, mode, suspensionState);

            Richting = (suspensionState.ContainsKey(nameof(Richting))) ? (Richting)suspensionState[nameof(Richting)] : (Richting)parameter;
            //IsLoggedIn = (suspensionState.ContainsKey(nameof(IsLoggedIn))) ? (Boolean)suspensionState[nameof(IsLoggedIn)] : (Boolean)parameter;
            //ProjectService p = ProjectService.Instance;

            //Views.Busy.SetBusy(true, "Laden");
            //await Task.Delay(500);
            //Views.Busy.SetBusy(false);
            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
            {
                suspensionState[nameof(Richting)] = Richting;

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
