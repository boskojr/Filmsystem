using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Data;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly MovieAPIContext _context;

        public PersonController(MovieAPIContext context)
        {
            _context = context;
        }

        [HttpGet("All-Person")]
        public ActionResult GetPersons() // Hämtar alla personer
        {
            return Ok(_context.Persons.ToList());
        }

        [HttpPost]
        public ActionResult AddPerson(Person person) // Lägger till en ny person
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
            return Ok(person);
        }
    }
}
