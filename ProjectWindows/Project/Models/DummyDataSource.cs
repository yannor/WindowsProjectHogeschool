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
            Html= "https://www.youtube.com/embed/YE8g2XkHXbg"
        };

        public static Richting RichtingOfficeManagement = new Richting()
        {
            Title = "Office Management",
            Description = "Je bent een doener en je houdt van uitdagingen. In een team ben jij diegene die organiseert en coördineert. Je weet van aanpakken en bent een punctuele multitasker. Voor jou moeten de zaken vooruitgaan, goed getimed en gepland. Talen zijn volledig je ding en je communiceert graag. Je blik is internationaal, je aanpak no-nonsense.",
            Html = "",
            Titel2= "Geen theorie zonder praktijk",
            PraktijkVoorop= "In het derde jaar bachelor trekken de studenten bedrijfsvertaler-tolk trekken een week naar de Oostkantons voor een intensieve training in vertaal- en tolkopdrachten. De studenten wonen voordrachten en sessies bij in het Frans, Engels, Duits en Spaans waarbij thema’s aan bod komen met economische, politieke, toeristische, en geschiedkundige achtergrond. De opdrachten bestaan o.a. uit consecutief tolken en het mondeling en schriftelijk synthetiseren van de voordrachten en de bezoeken in de verschillende vreemde talen. Op het einde van de week geeft iedere groep een mondelinge meertalige presentatie voor medestudenten en begeleiders met daarin de resultaten van de afgelopen seminarieweek."
                + "Daarnaast organiseert de faculteit elk jaar een internationale week met befaamde buitenlandse gastsprekers die lezingen en workshops geven: van software quality tot international negotiating,"
                + "van happiness in a cultural context tot een initiatie flamencodansen,"
                + "van El Cine espanol contemporaneo tot Une approche comparative de la presse française,.....Deze week biedt de studenten de kans hun diploma een internationaal tintje te geven.",
            Description2 = "De opleiding staat permanent in interactie met de beroepspraktijk. Vanaf het eerste jaar duik je al in de realiteit van het werkveld; onder meer via allerlei boeiende doestages, opdrachten, gastsprekers en projecten."
            + "Natuurlijk kan je daarbij rekenen op professionele ondersteuning: onze lectoren zijn allemaal vakspecialisten die je met plezier coachen en hun expertise graag met jou delen."
            + "HoGent - studenten worden opgeleid tot wereldburgers; vandaar dat je tijdens je studie een pak internationale en interculturele competenties zal verwerven.Buitenlandse gastsprekers, een internationale week, studeren of stage lopen in het buitenland als je wil, uitwisselingen, uitstappen en vele andere toffe activiteiten zullen je blik op de wereld enorm verruimen."
        };

        public static Campus Aalst = new Campus()
        {
            Uitleg = "Studeren aan HoGent campus Aalst betekent studeren in een gezellige provinciestad. Voor veel studenten is de HoGent in Aalst de campus vlakbij huis. De campus ligt dicht bij het centrum en de winkelstraat en is op wandelafstand van het station en de parking Keizershallen."
            + "Als student ben je er nooit anoniem en vind je er onmiddellijk je weg.HoGent campus Aalst staat voor een kleinschalige,"
            + "gerichte aanpak met veel aandacht voor het individu.Typerend zijn de kleine klasgroepen en het familiale karakter.Docenten gaan voor een persoonlijke aanpak en coachen heel gericht je competenties en talenten."
            + "Campus Aalst is bovendien zeer actief en heeft zoals de andere campussen van faculteit Bedrijf en Organisatie een sterk netwerk van nationale en internationale bedrijven.Theorie en praktijk gaan op de HoGent altijd hand in hand.Uniek is de inbreng van de lokale ondernemers.Zij bieden interessante stageplaatsen en werken mee aan heel wat initiatieven.Voor een gemotiveerde student de ideale opstap naar een boeiende job in de regio."

        };

        public static Richting RichtingBedrijfsManagement = new Richting()
        {
            Title = "Bedrijfsmanagement",
            Description = "De opleiding bedrijfsmanagement wil je actief begeleiden in je persoonlijke ontwikkeling en in de ontwikkeling van je competenties en talenten. Je krijgt een coach die met jou 1-to-1 je volledige studietraject begeleidt en je met raad en daad bijstaat. In het eerste jaar ligt de focus vooral op jezelf leren kennen als student en op je studieproces."
            +"In het tweede en het derde jaar ligt de focus op je persoonlijke ontwikkeling en op je beroepskeuze.Je coach bespreekt ook samen met jou de ideale stageplaats als voorbereiding op de job die je graag wil.Je leert ook meteen om een goed CV op te stellen dat vertrekt van je eigen sterktes.Heel belangrijk is dat jij altijd de centrale figuur bent in de coachingsessies.Jij bent altijd diegene die voor jezelf onderzoekt wat je kan en wat je wil.En je onderneemt ook eigen acties om jezelf bij te sturen naar een optimale slaagkans.",
            Html = ""
        };
    }
}
