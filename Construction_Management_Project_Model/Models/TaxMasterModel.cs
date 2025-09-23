using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Construction_Management_Project_Model.Models
{
    public class TaxMasterModel
    {
        [Key]

        public int Tax_Id { get; set; }

        [Required(ErrorMessage = "Tax Type is required")]
        [MaxLength(50)]
        public string? Tax_Type { get; set; }

        [Required(ErrorMessage = "Tax Percentage is required")]
        [Range(0, 100, ErrorMessage = "Tax Percentage must be between 0 and 100")]
        public decimal? Tax_Percentage { get; set; }

        [Required]
        public DateTime? EffectiveFrom { get; set; }

        public DateTime? EffectiveTo { get; set; }

        [MaxLength(250)]
        public string? Tax_Description { get; set; }

        public int? Created_By { get; set; }
        public int? Updated_By { get; set; }

        [Required]
        public DateTime Created_Date { get; set; } 

        [Required]
        public DateTime Updated_Date { get; set; }

        [Range(0, 1, ErrorMessage = "Acflag must be 0 or 1")]
        public int? Acflag { get; set; }

        [MaxLength(50)]
        public string? Saas_Id { get; set; }
    }
}
