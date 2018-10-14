namespace CoursesManagement.Domain
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Course Course { get; set; }
    }
}
