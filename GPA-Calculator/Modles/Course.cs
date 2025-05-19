using System.ComponentModel.DataAnnotations;

namespace GPA_Calculator.Modles
{
    public class Course
    {
        [Required]
        [Display(Name ="ID")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "the {0} must be at least {2} and at most {1}")]
        public required string CourseId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "the {0} must be at least {2} and at most {1}")]
        public required string CourseName { get; set; }

        [Required]
        [Range(1,4, ErrorMessage ="{0} must be between {1} and {2}")]
        public int Hours { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "{0} must be between {1} and {2}")]
        public int Grade { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "{0} must be between {1} and {2}")]
        public int Year { get; set; }

        [Required]
        [Range(1, 3, ErrorMessage = "{0} must be between {1} and {2}")]
        public int Semester {  get; set; }

        [Required]
        [Range(0, 4, ErrorMessage = "{0} must be between {1} and {2}")]
        public float Points { get; set; }
    }
}
