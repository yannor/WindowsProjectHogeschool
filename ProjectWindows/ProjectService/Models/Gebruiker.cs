using System;
using Newtonsoft.Json;

namespace ProjectService.Models
{
    public class Gebruiker
    {
        public int GebruikerID { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Wachtwoord { get; set; }

    }
}