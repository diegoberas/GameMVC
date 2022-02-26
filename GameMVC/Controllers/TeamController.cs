using GameMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace GameMVC.Controllers
{
    public class TeamController : Controller
    {
        private GameContext _context;

        public TeamController()
        {
            _context = new GameContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Team
        public ActionResult Index()
        {
            return View();
        }
    }
}