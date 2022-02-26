using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMVC.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname  { get; set; }
        public DateTime Birthdate { get; set; }
        public string Passport { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }

        // Relations
        public Team Team { get; set; }
        public int? TeamId { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }
    }
}