using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Data;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkPersonMovieGenreController : ControllerBase
    {
        private readonly MovieAPIContext _context;

        public LinkPersonMovieGenreController(MovieAPIContext context)
        {
            _context = context;
        }

        [HttpPost("Add/link-movie-person-genre")]
        public ActionResult AddMoviePersonGenre(LinkMoviePersonGenre link) // Lägger till länk för person, film, genre och rating
        {
            _context.Links.Add(link);
            _context.SaveChanges();

            return Ok(link);
        }

     

    }
}
