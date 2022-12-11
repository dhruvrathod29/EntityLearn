using System.ComponentModel.DataAnnotations;

namespace EntityLearn.Models
{
    public class Customer
    {

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [StringLength(250, ErrorMessage = "name must be less than or equals to 250 charcter")]
        public string Name { get; set; } = null!;

    }
}
