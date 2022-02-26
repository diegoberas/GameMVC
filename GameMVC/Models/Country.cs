using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMVC.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alpha2 { get; set; }
        public string Alpha3 { get; set; }
        public int NumericCode { get; set; }
        public string Iso { get; set; }

        // Relations
        public virtual ICollection<Team> Teams { get; set; }
    }
}