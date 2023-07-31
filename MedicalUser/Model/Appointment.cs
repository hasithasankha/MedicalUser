using IdentityServer4.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalUser.Model
{
    public class Appointment
    {
        [Key]
        public int APPOI_Id { get; set; } 

        [Required(ErrorMessage = "Please Select")]
        public string Appointment_List { get; set; }

        public virtual int CusId { get; set; }

        [ForeignKey("CusId")]
        public virtual Customer Customers { get; set; }
    }
}
