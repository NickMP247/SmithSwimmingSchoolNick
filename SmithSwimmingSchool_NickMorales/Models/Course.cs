using System.ComponentModel.DataAnnotations;

namespace SmithSwimmingSchool_NickMorales.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public int CoachID{ get; set; }
        public virtual Coach? Coach { get; set; }
        public string? Title { get; set; }

    }
}
