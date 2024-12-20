using System.ComponentModel.DataAnnotations;

namespace SmithSwimmingSchool_NickMorales.Models
{
    public class Swimmer
    {
        [Key]
        public int SwimmerID { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public Genre Genre { get; set; }
        public DateTime? BirthDate { get; set; }
    }
    public enum Genre
    {
        Male,
        Female,
        Others
    }
}
