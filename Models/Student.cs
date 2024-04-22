using System.ComponentModel.DataAnnotations;

namespace TestMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]        
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        public string RollNo { get; set; }
        public string Class { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
