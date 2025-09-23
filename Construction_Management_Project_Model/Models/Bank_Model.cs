using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_Management_Project_Model.Models
{
     public class Bank_Model
    {
        [Key]
        public int Bank_Id { get; set; }

        [Required(ErrorMessage = "Bank Name is required")]
        [MaxLength(150)]
        public string? Bank_Name { get; set; }

        [MaxLength(250)]
        public string? Remark { get; set; }

        public int? Created_By { get; set; }
        public int? Updated_By { get; set; }

        [Required]
        public DateTime Created_Date { get; set; } = DateTime.Now;

        [Required]
        public DateTime Updated_Date { get; set; } = DateTime.Now;

        [Range(0, 1, ErrorMessage = "Acflag must be 0 (Inactive) or 1 (Active)")]
        public int? Acflag { get; set; }

        [MaxLength(50)]
        public string? Saas_Id { get; set; }

    }
}


