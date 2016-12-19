namespace ProjectService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campus",
                c => new
                    {
                        CampusID = c.Int(nullable: false, identity: true),
                        Uitleg = c.String(),
                    })
                .PrimaryKey(t => t.CampusID);
            
            CreateTable(
                "dbo.Evenements",
                c => new
                    {
                        EvenementID = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Uitleg = c.String(),
                        Datum = c.DateTime(nullable: false),
                        Uur = c.String(),
                        Campus_CampusID = c.Int(),
                    })
                .PrimaryKey(t => t.EvenementID)
                .ForeignKey("dbo.Campus", t => t.Campus_CampusID)
                .Index(t => t.Campus_CampusID);
            
            CreateTable(
                "dbo.Gebruikers",
                c => new
                    {
                        GebruikerID = c.Int(nullable: false, identity: true),
                        Gebruikersnaam = c.String(),
                        Wachtwoord = c.String(),
                    })
                .PrimaryKey(t => t.GebruikerID);
            
            CreateTable(
                "dbo.Richtings",
                c => new
                    {
                        RichtingID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Titel2 = c.String(),
                        Description = c.String(),
                        Description2 = c.String(),
                        Html = c.String(),
                        Activiteiten = c.String(),
                        PraktijkVoorop = c.String(),
                        Voorkennis = c.String(),
                    })
                .PrimaryKey(t => t.RichtingID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Evenements", "Campus_CampusID", "dbo.Campus");
            DropIndex("dbo.Evenements", new[] { "Campus_CampusID" });
            DropTable("dbo.Richtings");
            DropTable("dbo.Gebruikers");
            DropTable("dbo.Evenements");
            DropTable("dbo.Campus");
        }
    }
}
