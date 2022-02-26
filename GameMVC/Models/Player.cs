﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameMVC.Models
{
    public class Player
    {
        public int Id { get; set; }


        [Display(Name = "* First Name")]
        public string Name { get; set; }


        [Display(Name = "* Last Name")]
        public string Lastname  { get; set; }


        [Display(Name = "* Date of Birth")]
        public DateTime Birthdate { get; set; }


        public string Passport { get; set; }


        public string Address { get; set; }


        [Display(Name = "* Sex (M / F)")]
        public string Sex { get; set; }


        // Relations
        public Team Team { get; set; }
        [Display(Name = "Team")]
        public int? TeamId { get; set; }


        public State State { get; set; }
        [Display(Name = "* Status")]
        public int StateId { get; set; }
    }
}