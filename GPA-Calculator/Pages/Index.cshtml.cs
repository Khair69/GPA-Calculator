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

        public async Task OnGetAsync()
        {
            Courses = await _courseService.GetAllCoursesAsync();
            double g = _calculateService.CalculateGPA(Courses);
            Console.WriteLine(g);
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
    }
}
