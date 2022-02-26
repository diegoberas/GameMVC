using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameMVC.Models;

namespace GameMVC.Controllers
{
    public class PlayerController : Controller
    {
        private GameContext _context;

        public PlayerController()
        {
            _context = new GameContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Player
        public ActionResult Index()
        {
            return View();
        }
    }
}