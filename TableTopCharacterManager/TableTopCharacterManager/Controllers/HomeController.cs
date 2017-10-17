using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TableTopCharacterManager.Models;

namespace TableTopCharacterManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly TableTopCharacterManagerContext _context;

        public HomeController(TableTopCharacterManagerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Character.Where(c => c.CharacterName != null);
            return View(result.ToList());
        }
    }
}