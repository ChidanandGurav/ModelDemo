using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ModelDemo.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Roll No is required")]
        [Display(Name = "Roll No")]
        public int RollNo { get; set; }


        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Student Name")]
        [MaxLength(40, ErrorMessage = "Name must have less than 40 characters")]
        [MinLength(2)]
        public string? Name { get; set;}


        [Required]
        [Display(Name = "City")]
        public string? City { get; set;}


        [Required]
        [Display(Name = "Percentage")]
        public double Percentage { get; set;}


        [Required]
        public string? Branch { get; set;}
    }
}
