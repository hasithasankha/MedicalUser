using System.ComponentModel.DataAnnotations;

namespace MedicalUser.Model 
{
    public class Drug
    {
        [Key]
        public int DrugId  { get; set; } 

        [Required(ErrorMessage ="Please Enter Trade Name")]
        public string Trde_Name { get; set; }

        [Required(ErrorMessage ="Please Enter Talet Generic Name")]
        public string Generic_Name { get; set; }

        [Required(ErrorMessage ="Please Enter Note ")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Noet cannot have less than 10 characters and more than 20 characters in length")]
        public string Note { get; set; }
    } 
}
