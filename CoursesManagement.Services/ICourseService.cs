using CoursesManagement.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoursesManagement.Services
{
    public interface ICourseService
    {
        Task<Course> AddCourse(Course course);

        Task<Course> UpdateCourse(Course course);

        Task<bool> DeleteCourse(int courseId);

        Task<Course> GetCourse(int courseId);

        Task<IEnumerable<Course>> GetCoursesByName(string name);

        Task<Grade> GetStudentGrade(int courseId, int studentId);

        Task<IEnumerable<Grade>> GetTeacherGrades(int courseId, int teacherId);
    }
}
