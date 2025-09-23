using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Construction_Management_Project_Model.Models
{
    public class Roll_Model
    {
        [Key]
        public int Roll_Id { get; set; }

        [Required(ErrorMessage = "Roll Name is required")]
        [MaxLength(100)]
        public string? Roll_Name { get; set; }

        [MaxLength(250)]
        public string? Remark { get; set; }

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
