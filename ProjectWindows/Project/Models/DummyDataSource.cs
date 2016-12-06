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
            Title="Toegepaste Informatica",
            Description = "De IT’er van vandaag is veel meer dan alleen maar een technische expert. Hij of zij moet tegelijkertijd een ondernemende, communicatieve en klantgerichte teamspeler zijn. IT is namelijk geëvolueerd van een zuiver technisch verhaal naar ’IT as a service and support tool’.",
            Html= "https://www.youtube.com/embed/YE8g2XkHXbg"
        };

        public static Richting RichtingOfficeManagement = new Richting()
        {
            Title = "Office Management",
            Description = "Je bent een doener en je houdt van uitdagingen. In een team ben jij diegene die organiseert en coördineert. Je weet van aanpakken en bent een punctuele multitasker. Voor jou moeten de zaken vooruitgaan, goed getimed en gepland. Talen zijn volledig je ding en je communiceert graag. Je blik is internationaal, je aanpak no-nonsense.",
            Html = ""
        };
    }
}
