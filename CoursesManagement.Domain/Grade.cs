namespace CoursesManagement.Domain
{
    public class Grade
    {
        public int Id { get; set; }

        public virtual Course Course { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual Student Student { get; set; }

        public decimal Value { get; set; }
    }
}
