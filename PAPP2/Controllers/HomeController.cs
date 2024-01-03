using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAPP2.Data;
using PAPP2.Models;
using System.Diagnostics;

namespace PAPP2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UnidadesCurriculares
        public async Task<IActionResult> Index()
        {
            return _context.UnidadesCurriculares != null ?
                        View(await _context.UnidadesCurriculares.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.UnidadesCurriculares'  is null.");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
