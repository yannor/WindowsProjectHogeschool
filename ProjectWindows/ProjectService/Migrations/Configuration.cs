namespace ProjectService.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjectService.Models.ProjectServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjectService.Models.ProjectServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Gebruikers.AddOrUpdate(
                g => g.GebruikerID,
                new Gebruiker { Gebruikersnaam = "Matthias", Wachtwoord = "SesamOpen" }
                );

            context.Campus.AddOrUpdate(
                c => c.CampusID,
                new Campus
                {
                    Uitleg = "Studeren aan HoGent campus Aalst betekent studeren in een gezellige provinciestad. Voor veel studenten is de HoGent in Aalst de campus vlakbij huis. De campus ligt dicht bij het centrum en de winkelstraat en is op wandelafstand van het station en de parking Keizershallen."
            + "Als student ben je er nooit anoniem en vind je er onmiddellijk je weg.HoGent campus Aalst staat voor een kleinschalige,"
            + "gerichte aanpak met veel aandacht voor het individu.Typerend zijn de kleine klasgroepen en het familiale karakter.Docenten gaan voor een persoonlijke aanpak en coachen heel gericht je competenties en talenten."
            + "Campus Aalst is bovendien zeer actief en heeft zoals de andere campussen van faculteit Bedrijf en Organisatie een sterk netwerk van nationale en internationale bedrijven.Theorie en praktijk gaan op de HoGent altijd hand in hand.Uniek is de inbreng van de lokale ondernemers.Zij bieden interessante stageplaatsen en werken mee aan heel wat initiatieven.Voor een gemotiveerde student de ideale opstap naar een boeiende job in de regio.",

                    Evenementen = new System.Collections.ObjectModel.ObservableCollection<Evenement>()
            {
                new Evenement {Naam = "Opendeurdag", Uitleg = "Kom gerust eens langs en kijk eens rond op de campus", Uur="14u - 16u", Datum = DateTime.Now.AddMonths(2) },
                new Evenement {Naam = "Projectvoorstelling", Uitleg = "Gaan we in de prijzen vallen? ;)" }
            }
                }
    );

        }
    }
}
