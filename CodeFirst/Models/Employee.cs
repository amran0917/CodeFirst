namespace CodeFirst.Models
{
    public class Employee
    {

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Salary { get; set; }
        public Department Departments { get; set; }
    }
}