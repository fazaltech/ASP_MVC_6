using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {

        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            var data=_context.Actors.ToList();
            return View();
        }
    }
}
