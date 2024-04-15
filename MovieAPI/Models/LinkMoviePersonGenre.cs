using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAPI.Models
{
    public class LinkMoviePersonGenre
    {
        [Key]
        public int LinkMoviePersonGenreID { get; set; }
        public string Link { get; set; }
        public int ? Rating { get; set; }
        public int MovieID { get; set; }
        public int PersonID { get; set; }
        public int GenreID { get; set; }

        
    }
}
