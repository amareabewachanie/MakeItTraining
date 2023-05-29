namespace DayThreeMVC.Models
{
    public class Company
    {
        public int Id { get; set; }    
        public string Name { get; set; }
        public string Address { get; set; }
        public string? Country { get; set; }
        // Navigational property 
        public ICollection<Employee>? Employees { get; set; }

    }
}
