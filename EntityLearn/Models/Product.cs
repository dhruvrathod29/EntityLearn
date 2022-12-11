using System.ComponentModel.DataAnnotations;

namespace EntityLearn.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [StringLength(250, ErrorMessage = "name must be less than or equals to 250 charcter")]
        public string Name { get; set; } = null!;
       

        [Required(ErrorMessage ="Enter Quantity")]
        [Range(1,250,ErrorMessage ="{0} must between {1} to {2}")]
        public int Quantity{ get; set; }

        [Required(ErrorMessage ="Enter Price")]
        [Range(1,double.MaxValue,ErrorMessage ="{0}  must between {1} to {2}")]
        public decimal Price { get; set; }
    }
}
