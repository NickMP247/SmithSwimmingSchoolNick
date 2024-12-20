using System.ComponentModel.DataAnnotations;

namespace SmithSwimmingSchool_NickMorales.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public Course? Course { get; set; }
        public int? SwimmerID { get; set; }
        public Swimmer? Swimmer { get; set; }
        public int? GroupID { get; set; }
        public Group? Group { get; set; }
       
    }
}
