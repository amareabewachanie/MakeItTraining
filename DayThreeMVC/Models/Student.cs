using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DayThreeMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please tell us your first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please tell us your middle name")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Please tell us your last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please tell us your department")]
        [StringLength(maximumLength:50,MinimumLength =4,ErrorMessage ="Department Name should be beteween 4 and 50 Characters long")]
        public string Department { get; set; }
    }
}
