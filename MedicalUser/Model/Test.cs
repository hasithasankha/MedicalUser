using IdentityServer4.Models;
using System.ComponentModel.DataAnnotations;

namespace MedicalUser.Model
{
    public class Test
    {
        [Key]
        public int TestId { get; set; }    

        [Required(ErrorMessage = "Please Enter Your Testing Name")]
        public string Test_Name { get; set; }

        [Required(ErrorMessage = "Please Enter Your Testing Description")]
        public string Test_Description { get; set; }
    }
}
