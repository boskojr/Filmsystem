using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
