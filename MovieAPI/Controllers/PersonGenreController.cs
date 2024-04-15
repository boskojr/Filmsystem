using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Data;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonGenreController : ControllerBase
    {
        private readonly MovieAPIContext _context;

        public PersonGenreController(MovieAPIContext context)
        {
            _context = context;
        }

        [HttpPost("Add-person-to-genre")]
        public ActionResult AddPersonGenre(PersonGenre personGenre) // Lägger till genre och person
        {
            _context.personGenres.Add(personGenre);
            _context.SaveChanges();
            return Ok(personGenre);
        }

        [HttpGet("Person/Genre/{id}")]
        public ActionResult GetPersonGenre(int id) // Hämtar genres som är kopplad till en person
        {
            var query = (from person in _context.Persons
                         join persongenre in _context.personGenres on person.PersonID equals persongenre.PersonID
                         join genre in _context.Genres on persongenre.GenreID equals genre.GenreID
                         where person.PersonID == id
                         select new
                         {
                             person.PersonID,
                             person.Name,
                             genre.GenreID,
                             genre.Titel,
                             genre.Description

                         }).ToList();
            
            return Ok(query);

        }
    }
}
