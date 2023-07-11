using IdentityServer4.Models;
using System.ComponentModel.DataAnnotations;

namespace MedicalUser.Model
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Your Name is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name cannot have less than 3 characters and more than 20 characters in length")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Your Address is required")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Your Email is required")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
