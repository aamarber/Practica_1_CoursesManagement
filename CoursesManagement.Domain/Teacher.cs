using System.Collections.Generic;

namespace CoursesManagement.Domain
{
    public class Teacher
    {
        public Teacher()
        {
            Courses = new List<Course>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IList<Course> Courses { get; set; }
    }
}
