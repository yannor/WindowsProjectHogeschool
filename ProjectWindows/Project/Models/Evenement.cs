using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    class Evenement
    {
        public string Naam { get; set; }
        public string Uitleg { get; set; }
        public DateTime Datum { get; set; }
        public int Startuur { get; set; }
        public int Einduur { get; set; }
    }
}
