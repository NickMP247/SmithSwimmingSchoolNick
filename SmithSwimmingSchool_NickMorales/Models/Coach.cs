using System.ComponentModel.DataAnnotations;

namespace SmithSwimmingSchool_NickMorales.Models
{
    public class Coach
    {
        [Key]
        public int CoachID { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
