using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class DummyDataSource
    {

        public static Richting RichtingToegepasteInformatica = new Richting()
        {
            Title = "Toegepaste Informatica",
            Description = "De IT’er van vandaag is veel meer dan alleen maar een technische expert. Hij of zij moet tegelijkertijd een ondernemende, communicatieve en klantgerichte teamspeler zijn. IT is namelijk geëvolueerd van een zuiver technisch verhaal naar ’IT as a service and support tool’.",
            Html = ""
        };

        public static Richting RichtingOfficeManagement = new Richting()
        {
            Title = "Office Management",
            Description = "Je bent een doener en je houdt van uitdagingen. In een team ben jij diegene die organiseert en coördineert. Je weet van aanpakken en bent een punctuele multitasker. Voor jou moeten de zaken vooruitgaan, goed getimed en gepland. Talen zijn volledig je ding en je communiceert graag. Je blik is internationaal, je aanpak no-nonsense.",
            Html = ""
        };

        public static Campus Aalst = new Campus()
        {
            Uitleg = "Studeren aan HoGent campus Aalst betekent studeren in een gezellige provinciestad. Voor veel studenten is de HoGent in Aalst de campus vlakbij huis. De campus ligt dicht bij het centrum en de winkelstraat en is op wandelafstand van het station en de parking Keizershallen."
            + "Als student ben je er nooit anoniem en vind je er onmiddellijk je weg.HoGent campus Aalst staat voor een kleinschalige,"
            + "gerichte aanpak met veel aandacht voor het individu.Typerend zijn de kleine klasgroepen en het familiale karakter.Docenten gaan voor een persoonlijke aanpak en coachen heel gericht je competenties en talenten."
            + "Campus Aalst is bovendien zeer actief en heeft zoals de andere campussen van faculteit Bedrijf en Organisatie een sterk netwerk van nationale en internationale bedrijven.Theorie en praktijk gaan op de HoGent altijd hand in hand.Uniek is de inbreng van de lokale ondernemers.Zij bieden interessante stageplaatsen en werken mee aan heel wat initiatieven.Voor een gemotiveerde student de ideale opstap naar een boeiende job in de regio."

        };
    }
}
