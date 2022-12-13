
using System.ComponentModel.DataAnnotations;

namespace EntityLearn.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }


        [Required(ErrorMessage = "Enter Name")]
        [StringLength(250, ErrorMessage = "name must be less than or equals to 250 charcter")]
        public string StudentName { get; set; } = null!;


        [Required(ErrorMessage = "Enter Enrollment no")]
        [Range(1, 12, ErrorMessage = "{0} must between {1} to {2}")]
        public int EnrollmentNo { get; set; }
        

        [Required(ErrorMessage = "Enter Plase Address")]
        [StringLength(250, ErrorMessage = "Address must be less than or equals to 250 charcter")]
        public string Address { get; set; } = null!;


        [Required(ErrorMessage ="Enter Email")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string StudentEmail { get; set;} = null!;

        [Required(ErrorMessage = "Enter Contact No")]
        [StringLength(50, ErrorMessage = "Contact no must be less than or quals to 50 charcter")]
        public string ContactNo { get; set; } = null!;

        



    }
}
