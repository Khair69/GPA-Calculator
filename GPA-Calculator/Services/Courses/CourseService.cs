using GPA_Calculator.Data;
using GPA_Calculator.Modles;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace GPA_Calculator.Services.Courses
{
    public class CourseService : ICourseService
    {
        private readonly AppDbContext _context;

        public CourseService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddCourseAsync(Course course)
        {
            _context.Courses.Add(course);

            var res = await _context.SaveChangesAsync();
            return res == 1;
        }

        public async Task<IList<Course>> GetAllCoursesAsync()
        {
            return await _context.Courses
                .OrderBy(c => c.Year)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Course> GetCourseByIdAsync(string id)
        {
            return await _context.Courses
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CourseId == id);
        }

        public Task<bool> DeleteCourseAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCourseAsync(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
