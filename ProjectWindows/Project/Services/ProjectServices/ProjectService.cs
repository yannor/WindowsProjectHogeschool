using Project.Models;
using Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.ProjectService
{
    public class ProjectService
    {
        private static ProjectService _instance;
        /// <summary>
        /// Lazy initialization van de LoginService
        /// </summary>
        public static ProjectService Instance { get { return _instance ?? (_instance = new ProjectService()); } }
        
        public bool IsLoggedIn { get; set; }

        public Gebruiker CurrentUSer { get; set; }

        public bool IsInEditMode { get; set; }
        
    }
}
