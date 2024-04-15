using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;

namespace MovieAPI.Data
{
    public class MovieAPIContext : DbContext
    {

        public MovieAPIContext(DbContextOptions<MovieAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<PersonGenre> personGenres { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<LinkMoviePersonGenre> Links { get; set; }

    }
}
