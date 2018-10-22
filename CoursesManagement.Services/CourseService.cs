using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursesManagement.Domain;
using CoursesManagement.Repository;

namespace CoursesManagement.Services
{
    public class CourseService : ICourseService
    {
        private CoursesContext context;

        public CourseService(CoursesContext context)
        {
            this.context = context;
        }

        public async Task<Course> AddCourse(Course course)
        {
            context.Courses.Add(course);
            var id = await context.SaveChangesAsync().ConfigureAwait(false);

            return await context.Courses.FindAsync(id).ConfigureAwait(false);
        }

        public async Task<bool> DeleteCourse(int courseId)
        {
            var course = await context.Courses.FindAsync(courseId).ConfigureAwait(false);
            context.Courses.Remove(course);

            return true;
        }

        public async Task<Course> GetCourse(int courseId)
        {
            return await context.Courses.FindAsync(courseId).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Course>> GetCoursesByName(string name)
        {
            return context.Courses.Where(x => x.Name == name);
        }

        public async Task<Grade> GetStudentGrade(int courseId, int studentId)
        {
            return context.Grades.SingleOrDefault(x => x.Course.Id == courseId && x.Student.Id == studentId);
        }

        public async Task<IEnumerable<Grade>> GetTeacherGrades(int courseId, int teacherId)
        {
            return context.Grades.Where(x => x.Course.Id == courseId && x.Teacher.Id == teacherId);
        }

        public async Task<Course> UpdateCourse(Course course)
        {
            context.Courses.Update(course);

            return course;
        }
    }
}
