namespace SchoolApp.Models

{
    public class Course
    {
        public int CourseId { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public string Credits { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<Student> Students { get; set; }

        
    }
}

