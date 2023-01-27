using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace SchoolApp.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public int Number { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }
        public string Office { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
