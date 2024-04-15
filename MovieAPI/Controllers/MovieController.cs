using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Data;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieAPIContext _context;

        public MovieController(MovieAPIContext context)
        {
            _context = context;
        }


        [HttpGet]
        public ActionResult GetMovies() // Hämtar alla filmer
        {
            return Ok(_context.Movies.ToList());
        }


        [HttpPost]
        public ActionResult AddMovie(Movie movie) // Lägger till en ny film
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return Ok(movie);
        }

        [HttpGet("Person/{id}")]
        public ActionResult GetMovieByPerson(int id) // Hämtar filmer som är kopplad till en person
        {
   
                var query = (from movie in _context.Movies
                             join personlink in _context.Links on movie.MovieID equals personlink.MovieID
                             where personlink.PersonID == id
                             select new Movie
                             {
                                 MovieID = movie.MovieID,
                                 Lenght = movie.Lenght,
                                 Year = movie.Year,
                                 Name = movie.Name


                             }).ToList();


                return Ok(query);

            
        }


        [HttpGet("Rating/Person/{id}")]
        public ActionResult GetRating(int id)//Hämtar rating till filmer som är kopplad till en person
        {

            var query = (from movie in _context.Movies
                        join link in _context.Links on movie.MovieID equals link.MovieID
                        where link.PersonID == id
                        select new
                        {
                            link.Rating,
                            movie.Name
                        }).ToList();

            




            return Ok(query);
        }


    }
}
