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
        public string? Emp_Code { get; set; }
        public string? Emp_Name { get; set; }
        public string? Emp_Phone { get; set; }
        public string? Emp_Pan { get; set; }
        public string? Emp_Contact { get; set; }
        public string? Emp_Email { get; set; }
        public string? Emp_Bank_id { get; set; }
        public string? Emp_Branch { get; set; }
        public string? Emp_Account { get; set; }
        public string? Emp_Address { get; set; }
    }
}
