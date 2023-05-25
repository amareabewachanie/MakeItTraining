namespace EmployeeManagmentMvc.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
