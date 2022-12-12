using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace EntityLearn.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }


        [Required(ErrorMessage = "Enter Name")]
        [StringLength(250, ErrorMessage = "name must be less than or equals to 250 charcter")]
        public string StudentName { get; set;}


        [Required(ErrorMessage ="Enter Enrollment no")]
        public int EnrollmentNo { get; set; }
        public string Address { get; set; }

        public string StudentEmail { get; set;}
        public string ContactNo { get; set;}
        public DateTime BirthDate { get; set;}



    }
}
