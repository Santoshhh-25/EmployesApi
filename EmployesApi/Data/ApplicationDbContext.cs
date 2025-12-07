using EmployesApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployesApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
