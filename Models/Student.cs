using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Models
{

        public enum Grade
        {
            A, B, C, D, F
        }

        public class Student
    {
        public int StudentId { get; set; }
        public int Number { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment")] 
        public DateTime Enrollment { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }


        public ICollection<Department> Departments { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
