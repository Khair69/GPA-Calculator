using GPA_Calculator.Modles;

namespace GPA_Calculator.Services.Courses
{
    public interface ICourseService
    {
        Task<IList<Course>> GetAllCoursesAsync();
        Task<Course> GetCourseByIdAsync(string id);
        Task<bool> AddCourseAsync(Course course);
        Task<bool> DeleteCourseAsync(string id);
        Task<bool> UpdateCourseAsync(Course course);
    }
}
