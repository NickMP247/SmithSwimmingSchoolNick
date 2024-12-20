using System.ComponentModel.DataAnnotations;

namespace SmithSwimmingSchool_NickMorales.Models
{
    public class Report
    {
        [Key]
        public int ReportID { get; set; }
        public string? Description { get; set; }
        public int? EnrollmentID {  get; set; }
        public virtual Enrollment? Enrollment { get; set; }

    }
}
