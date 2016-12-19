using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Gebruiker
    {
        public Gebruiker()
        {

        }

        public Gebruiker(String username, String password)
        {
            Gebruikersnaam = username;
            Wachtwoord = password;
        }

        public int GebruikerID { get; set; }

        public String Gebruikersnaam { get; private set; }


        /// <summary>
        /// Todo: WW encrypteren?
        /// </summary>
        public String Wachtwoord { get; private set; }
    }
}
