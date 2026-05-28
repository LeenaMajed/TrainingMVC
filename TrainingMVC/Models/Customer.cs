using System.ComponentModel.DataAnnotations;

namespace TrainingMVC.Models
{
    public class Customer
    {
        
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Mobile number is required")]

        public string MobileNo { get; set; }

        [EmailAddress(ErrorMessage = "Write a correct email format")]
        public string Email { get; set; }
        [Required(ErrorMessage = "City is required")]

        public string City { get; set; }

        
    }
}
