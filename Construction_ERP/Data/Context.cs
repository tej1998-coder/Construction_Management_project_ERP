using Construction_Management_Project_Model.Models;
using Microsoft.EntityFrameworkCore;
namespace Construction_ERP.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        public DbSet<EmployeeMaster_Model> Employee_Table { get; set; }
    }
}
