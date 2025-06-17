using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ST10038389_PROG7311___POE_PART_2.Models;
using ST10038389_PROG7311_PART_2_OF_POE.Models;

namespace ST10038389_PROG7311_PART_2_OF_POE.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
//--------------------------------- END OF FILE ------------------------------------------------------------------------------------