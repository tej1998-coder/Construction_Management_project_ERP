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
        public string? Tax_Type { get; set; }
        public decimal? Tax_Percentage { get; set; }
        public Date? EffectiveFrom { get; set; }
        public Date? EffectiveTo { get; set; }
        public string? Tax_Description { get; set; }
        public int? Created_By { get; set; }
        public int? Updated_By { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Updated_Date { get; set; }
        public int? Acflag { get; set; }
        public string? Saas_Id { get; set; }
    }
}
