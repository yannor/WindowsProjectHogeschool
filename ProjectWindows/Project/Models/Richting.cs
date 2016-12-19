using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Richting
    {
        public string Title { get; set; }
        public string Titel2 { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }

        public List<string> Opsomming1 { get; set; }
        public List<string> Opsomming2 { get; set; }

        public string Html { get; set; }
        public string Activiteiten { get; set; }
        public string PraktijkVoorop { get; set; }
        public string Voorkennis { get; set; }
    }
}
