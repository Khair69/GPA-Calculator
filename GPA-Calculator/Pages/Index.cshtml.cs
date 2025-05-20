using GPA_Calculator.Modles;
using GPA_Calculator.Services.Calculate;
using GPA_Calculator.Services.Courses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GPA_Calculator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICourseService _courseService;
        private readonly ICalculateService _calculateService;

        public IndexModel(ICourseService courseService, ICalculateService calculateService)
        {
            _courseService = courseService;
            _calculateService = calculateService;
        }

        public IList<Course> Courses { get; set; }
        public double GPA { get; set; }

        public async Task OnGetAsync()
        {
            Courses = await _courseService.GetAllCoursesAsync();
            GPA = _calculateService.CalculateGPA(Courses);
        }

        [BindProperty]
        public Course NewCourse { get; set; }

        public async Task<IActionResult> OnPostAddCourseAsync()
        {
            if (!ModelState.IsValid)
            {
                // Reload items if validation fails
                Courses = await _courseService.GetAllCoursesAsync();
                return Page();
            }

            await _courseService.AddCourseAsync(NewCourse);
            return RedirectToPage(); // PRG pattern
        }

        public async Task<JsonResult> OnGetCourseDataAsync()
        {
            Courses = await _courseService.GetAllCoursesAsync();
            var data = Courses.Select(c => new
            {
                courseName = c.CourseName,
                grade = c.Grade,
                hours = c.Hours,
                id = c.CourseId
            }).ToList();

            return new JsonResult(data);
        }
    }
}
