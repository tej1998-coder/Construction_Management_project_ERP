using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_Management_Project_Model.Models
{
    public class User_Registration_Model
    {
        [Key]
        public int User_id { get; set; }
        public int? Employee_id { get; set; }
        public int? Roll_Id { get; set; }
        public string? User_Name { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Token_key { get; set; }
        public string? User_Password { get; set; }
        public int? Created_by { get; set; }
        public DateTime Created_date { get; set; }
        public int? Updated_by { get;set; }
        public DateTime Updated_date { get;set; }
        public string? Ac_flag { get; set; } 




    }

}

