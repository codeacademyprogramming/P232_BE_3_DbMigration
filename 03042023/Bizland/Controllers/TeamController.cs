using Bizland.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Bizland.Controllers
{
    public class TeamController : Controller
    {
        private readonly DataContext _context;

        public TeamController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.TeamMembers.ToList();
            return View(data);
        }

        public IActionResult Detail(int id)
        {
            var tm = _context.TeamMembers.Find(id);

            if (tm == null) return View("Error");

            return View(tm);
        }
    }
}
