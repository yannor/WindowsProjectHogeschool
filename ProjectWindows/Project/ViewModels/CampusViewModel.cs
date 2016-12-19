using Project.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace Project.ViewModels
{
    public class CampusViewModel : ViewModelBase
    {
        public ObservableCollection<Evenement> Evenementen { get; set; }

        public CampusViewModel()
        {
        }



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


    }
}
