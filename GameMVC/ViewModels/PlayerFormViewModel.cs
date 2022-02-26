using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameMVC.Models;

namespace GameMVC.ViewModels
{
    public class PlayerFormViewModel
    {
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<State> States { get; set; }
        public Player Player { get; set; }

    }
}