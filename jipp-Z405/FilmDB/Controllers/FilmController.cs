using FilmDB.Data;
using FilmDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        private FilmContext _context;
        public FilmController( FilmContext context )
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var film = new FilmModel();
            film.Id = 0;
            film.Title = "Tenet";
            film.Year = "2020";
            _context.Films.Add(film);
            _context.SaveChanges();

            return View();
        }
    }
}
