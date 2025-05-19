using GPA_Calculator.Modles;

namespace GPA_Calculator.Services.Calculate
{
    public interface ICalculateService
    {
        double CalculateGPA(IList<Course> courses);
    }
}
