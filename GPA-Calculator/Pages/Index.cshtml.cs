using GPA_Calculator.Modles;
using GPA_Calculator.Services.Courses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GPA_Calculator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICourseService _courseService;

        public IndexModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public Course NewCourse { get; set; }

        public async Task<IActionResult> OnPostAddCourseAsync()
        {
            if (!ModelState.IsValid)
            {
                // Reload items if validation fails
                return Page();
            }

            await _courseService.AddCourseAsync(NewCourse);
            return RedirectToPage(); // PRG pattern
        }
    }
}
