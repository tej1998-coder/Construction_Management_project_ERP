using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_Management_Project_Model.Models
{
    public class ErrorLog_Model
    {
        [Key] 
       public int ErrorLog_Id { get; set; }
        [Required]
       public System.DateTime ErrorLog_Date { get; set; }
        [StringLength(200)]
       public string?  controller_name  { get; set; }
        [StringLength(200)]
        public string? ActionMethodName { get; set; }
        [Required]
        public string? Data { get; set; }
        public int? Flag { get; set; }
    }
}
