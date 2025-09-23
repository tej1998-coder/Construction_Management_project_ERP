using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_Management_Project_Model.Models
{
    public class User_Registration_Model
    {
        [Key]
        public int User_id { get; set; }

        [ForeignKey("Employee")]
        public int? Employee_id { get; set; }

        [ForeignKey("Roll")]
        public int? Roll_Id { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        [MaxLength(100)]
        public string? User_Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email format")]
        [MaxLength(100)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MaxLength(200)]
        public string? Password { get; set; }   

        [MaxLength(250)]
        public string? Token_key { get; set; }

        [NotMapped]  
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string? User_Password { get; set; }

        public int? Created_by { get; set; }

        [Required]
        public DateTime Created_date { get; set; } 

        public int? Updated_by { get; set; }

        [Required]
        public DateTime Updated_date { get; set; } 

        [MaxLength(1)]
        public string? Ac_flag { get; set; }




    }

}

