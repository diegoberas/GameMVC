using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMVC.Models
{
    public class State
    {
        public int Id { get; set; }
        public string NameState { get; set; }
        public DateTime CreationDate { get; set; }

        // Relations
        public virtual ICollection<Player> Players { get; set; }


    }
}