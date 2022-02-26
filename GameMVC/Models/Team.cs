using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMVC.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime CreationDate { get; set; }

        // Relations
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public virtual ICollection<Player> Players { get; set; }
  

    }
}