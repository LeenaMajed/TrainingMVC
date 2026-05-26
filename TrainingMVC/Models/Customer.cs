using System.ComponentModel.DataAnnotations;

namespace TrainingMVC.Models
{
    public class Customer
    {
        
        public int CustomerID { get; set; }
        [Required]
        public string CustomerName { get; set; }

        public string MobileNo { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string City { get; set; }
    }
}
