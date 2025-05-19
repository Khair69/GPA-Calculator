using GPA_Calculator.Modles;

namespace GPA_Calculator.Services.Calculate
{
    public class CalculateService : ICalculateService
    {
        public double CalculateGPA(IList<Course> courses)
        {
            float totMulti = 0;
            int totHours = 0;
            foreach (var c in courses)
            {
                totMulti += (c.Hours * c.Points);
                totHours += c.Hours;
            }
            return totMulti/totHours;
        }
    }
}
