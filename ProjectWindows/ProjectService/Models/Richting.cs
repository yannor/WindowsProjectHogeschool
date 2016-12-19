using Newtonsoft.Json;
using System;


namespace ProjectService.Models
{
    public class Richting
    {
        public int RichtingID { get; set; }
        public string Title { get; set; }
        public string Titel2 { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }

        public string Html { get; set; }
        public string Activiteiten { get; set; }
        public string PraktijkVoorop { get; set; }
        public string Voorkennis { get; set; }
    }
}
