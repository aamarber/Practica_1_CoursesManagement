namespace CoursesManagement.Domain
{
    public class Grade
    {
        public int Id { get; set; }

        public Course Course { get; set; }

        public Teacher Teacher { get; set; }

        public Student Student { get; set; }

        public decimal Value { get; set; }
    }
}
