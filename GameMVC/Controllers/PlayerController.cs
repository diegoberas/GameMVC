using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameMVC.Models;
using System.Data.Entity;
using GameMVC.ViewModels;
using Microsoft.Ajax.Utilities;

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

        // GET: Player/index
        public ActionResult Index()
        {
            var getPlayers = _context.Players.Include(t => t.Team).ToList();

            return View(getPlayers);
        }

        // GET: Player/Show/{id}
        public ActionResult Show(int id)
        {
            var showPlayer = _context.Players.Include(t => t.Team).Include(t => t.State).SingleOrDefault(p => p.Id == id);
            if (showPlayer == null)
                return HttpNotFound();

            return View(showPlayer);
        }

        //POST: Player Form
        [HttpPost]
        public ActionResult Save(Player player)
        {
            var findPlayer = _context.Players.SingleOrDefault(p => p.Id == player.Id);
            if (findPlayer == null)
            {
                _context.Players.Add(player);
            }
            else
            {
                findPlayer.Name = player.Name;
                findPlayer.Lastname = player.Lastname;
                findPlayer.Birthdate = player.Birthdate;
                findPlayer.Passport = player.Passport;
                findPlayer.Address = player.Address;
                findPlayer.Sex = player.Sex;
                findPlayer.TeamId = player.TeamId;
                findPlayer.StateId = player.StateId;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Player");

        }

        //GET: Player/New
        public ActionResult New()
        {
            var team = _context.Teams.ToList();
            var status = _context.States.ToList();
            var viewModel = new PlayerFormViewModel()
            {
                Teams = team,
                States = status
            };
            return View("PlayerForm", viewModel);
        }

    }
}