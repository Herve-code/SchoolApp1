namespace SchoolApp.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string Administrator { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
    }
}
