using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameMVC.Models;

namespace GameMVC.ViewModels
{
    public class TeamFormViewModel
    {
        public Team Team { get; set; }

        public IEnumerable<Country> Countries { get; set; }
    }
}