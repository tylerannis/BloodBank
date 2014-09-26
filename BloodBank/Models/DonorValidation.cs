using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace BloodBank.Models
{
    [MetadataType(typeof(DonorValidation))]
    public partial class Donors2
    {
    }
    public class DonorValidation
    {
        [Required]
        public string DonorName { get; set; }
        [Required]    
        public string DonorBloodGroup { get; set; }
        public string DonorMedicalreport { get; set; }
        public string DonorAddress { get; set; }
        [Required, Phone]
        public string DonorContactInfo { get; set; }
    }
}