using System.ComponentModel.DataAnnotations;

namespace GPA_Calculator.Modles
{
    public class Course
    {
        [Required]
        [Display(Name ="ID")]
        public string CourseId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string CourseName { get; set; }

        [Required]
        public int Hours { get; set; }

        [Required]
        public int Grade { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int Semester {  get; set; }

        [Required]
        public float Points { get; set; }
    }
}
