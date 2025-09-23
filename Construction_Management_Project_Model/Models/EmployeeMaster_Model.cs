using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Construction_Management_Project_Model.Models
{
    [Table("Employee_Table")]
    public class EmployeeMaster_Model
    {
        [Key]
        public int Emp_id { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Emp_Code { get; set; } 

        [Required]
        [MaxLength(100)]
        public string? Emp_Name { get; set; } 

        [Required]
        [Phone]
        [MaxLength(15)]
        public string? Emp_Phone { get; set; } 

        [MaxLength(20)]
        public string? Emp_Pan { get; set; }

        [MaxLength(15)]
        public string? Emp_Contact { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string? Emp_Email { get; set; }

        [MaxLength(50)]
        public string? Emp_Bank_id { get; set; }

        [MaxLength(50)]
        public string? Emp_Branch { get; set; }

        [MaxLength(30)]
        public string? Emp_Account { get; set; }

        [MaxLength(200)]
        public string? Emp_Address { get; set; }
  
    }
}

