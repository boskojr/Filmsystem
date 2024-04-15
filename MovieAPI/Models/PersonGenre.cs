using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAPI.Models
{
    public class PersonGenre
    {
        [Key]
        public int PersonGenreID { get; set; }
        public int PersonID { get; set; }
        public int GenreID { get; set; }

      


    }
}
