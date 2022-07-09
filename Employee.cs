namespace BlazorApp1.Data
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DAteOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
    }
}
