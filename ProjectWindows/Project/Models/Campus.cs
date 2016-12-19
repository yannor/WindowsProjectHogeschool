using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Campus
    {
        public ObservableCollection<Evenement> Evenementen { get; set; }
        public string Uitleg { get; set; }
    }
}
