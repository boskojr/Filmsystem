using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string Name { get; set; }
        public int Lenght { get; set; }
        public int Year { get; set; }
    }
}
