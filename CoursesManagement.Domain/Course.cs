using System.Collections.Generic;

namespace CoursesManagement.Domain
{
    public class Course
    {
        public Course()
        {
            Students = new List<Student>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual IList<Student> Students { get; set; }
    }
}
