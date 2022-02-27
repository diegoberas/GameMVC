using GameMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using GameMVC.ViewModels;

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

        // GET: Team/Index
        public ActionResult Index()
        {
            var getTeam = _context.Teams.Include(t => t.Players).Include(t => t.Country).ToList();
            return View(getTeam);
        }

        // GET: Team/Show/{id}
        public ActionResult Show(int id)
        {
            var showTeam = _context.Teams.Include(t => t.Players).Include(t => t.Country).SingleOrDefault(p => p.Id == id);

            if (showTeam == null)
                return HttpNotFound();
            

            return View(showTeam);
        }

        //POST: Team Form
        [HttpPost]
        public ActionResult Save(Team team)
        {
            var findTeam = _context.Teams.SingleOrDefault(t => t.Id == team.Id);
            if (findTeam == null)
            {
                _context.Teams.Add(team);
            }
            else
            {
                findTeam.Name = team.Name;
                findTeam.Status = team.Status;
                findTeam.CreationDate = team.CreationDate;
                findTeam.CountryId = team.CountryId;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Team");

        }

        //GET: Team/New
        public ActionResult New()
        {
            var country = _context.Countries.ToList();
            var viewModel = new TeamFormViewModel()
            {
                Countries = country
            };
            return View("TeamForm", viewModel);
        }

        //EDIT: Team/Edit/{id}
        public ActionResult Edit(int id)
        {
            var team = _context.Teams.SingleOrDefault(c => c.Id == id);
            var editTeam = new TeamFormViewModel()
            {
                Team = team,
                Countries = _context.Countries.ToList(),
            };

            return View("TeamForm", editTeam);
        }

        //DELETE: Team/Delete/{id}
        public ActionResult Delete(int id)
        {
            var team = _context.Teams.Include(t => t.Players).Include(t => t.Country).SingleOrDefault(p => p.Id == id);
            if (team == null)
                return HttpNotFound();

            _context.Teams.Remove(team);
            _context.SaveChanges();
            return RedirectToAction("Index", "Team");
        }

    }
}