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

namespace Project.ViewModels
{
    public class RichtingViewModel : ViewModelBase
    {
        

        public RichtingViewModel()
        {
        }

        private Richting _richting; 
        public Richting Richting {
            get { return _richting; }
            set { _richting = value;RaisePropertyChanged(); }
        }
        
        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            
            Richting = (suspensionState.ContainsKey(nameof(Richting))) ? (Richting)suspensionState[nameof(Richting)] : (Richting)parameter;
            Views.Busy.SetBusy(true, "Laden");
            await Task.Delay(3000);
            Views.Busy.SetBusy(false);
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
