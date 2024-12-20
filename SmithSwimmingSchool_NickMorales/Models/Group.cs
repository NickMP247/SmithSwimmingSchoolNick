using System.ComponentModel.DataAnnotations;

namespace SmithSwimmingSchool_NickMorales.Models
{
    public class Group
    {
        [Key]
        public int GroupID { get; set; }
        public Level Level { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Places { get; set; }
    }
    public enum Level
    {
        Beginner,
        Intermediate, 
        Advanced, 
        Professional
    }
}
