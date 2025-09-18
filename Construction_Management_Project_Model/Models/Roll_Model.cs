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
        public string? Roll_Name { get; set; }
        public string? Remark { get; set; }
        public int? Created_By { get; set; }
        public int? Updated_By { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Updated_Date { get; set; }
        public int? Acflag { get; set; }
        public string? Saas_Id { get; set; }
    }
}
