using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Data;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly MovieAPIContext _context;

        public GenreController(MovieAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetGenre() // Hämtar alla genres
        {
            return Ok(_context.Genres.ToList());

        }

        [HttpPost]
        public ActionResult AddGenre(Genre genre) // Lägger till en ny genre
        {
            _context.Genres.Add(genre);
            _context.SaveChanges();
            return Ok(genre);
        }

      
    }
}
