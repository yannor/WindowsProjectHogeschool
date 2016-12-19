using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProjectService.Models
{
    public class Campus
    {
        public int CampusID { get; set; }
        public virtual ICollection<Evenement> Evenementen { get; set; }
        public string Uitleg { get; set; }
    }
}
