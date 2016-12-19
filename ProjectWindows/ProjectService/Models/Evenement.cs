using System;
using Newtonsoft.Json;

namespace ProjectService.Models
{
    public class Evenement
    {
        public int EvenementID { get; set; }
        public string Naam { get; set; }
        public string Uitleg { get; set; }
        public DateTime Datum { get; set; }
        public string Uur { get; set; }

    }
}
