using System.Collections.Generic;

namespace CoursesManagement.Domain
{
    public class Course
    {
        public Course()
        {
            Students = new List<Student>();

            Grades = new List<Grade>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual IList<Student> Students { get; set; }

        public virtual IList<Grade> Grades { get; set; }
    }
}