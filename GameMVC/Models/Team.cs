using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameMVC.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Display(Name = "* Name")]
        public string Name { get; set; }



        [Display(Name = "* Team Status")]
        public string Status { get; set; }



        [Display(Name = "* Founded")]
        public DateTime CreationDate { get; set; }


        // Relations
        public Country Country { get; set; }
        [Display(Name = "* Country ISO3")]
        public int CountryId { get; set; }

        public virtual ICollection<Player> Players { get; set; }


    }
}