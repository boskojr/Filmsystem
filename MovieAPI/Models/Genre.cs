using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }
    }
}
