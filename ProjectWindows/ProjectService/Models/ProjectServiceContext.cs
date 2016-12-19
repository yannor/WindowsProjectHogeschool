using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectService.Models
{
    public class ProjectServiceContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProjectServiceContext() : base("name=ProjectServiceContext")
        {
        }

        public System.Data.Entity.DbSet<ProjectService.Models.Evenement> Evenements { get; set; }

        public System.Data.Entity.DbSet<ProjectService.Models.Campus> Campus { get; set; }

        public System.Data.Entity.DbSet<ProjectService.Models.Richting> Richtings { get; set; }

        public System.Data.Entity.DbSet<ProjectService.Models.Gebruiker> Gebruikers { get; set; }
    }
}
