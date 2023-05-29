namespace DayThreeMVC.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public int CompanyId { get; set; }
        // Navigational property
        public Company Company { get; set; }
    }
}
