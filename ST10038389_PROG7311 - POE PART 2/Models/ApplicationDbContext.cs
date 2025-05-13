using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ST10038389_PROG7311___POE_PART_2.Models;

namespace ST10038389_PROG7311___POE_PART_2.Data
{
    //Database Connection to Farmers and Product Page.
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Farmer> Farmers { get; set; }
        //Getters for Farmer
        //Setters for Farmer
        public DbSet<Product> Products { get; set; }
        //Getters for Product - Gets the product data
        //Setters for Product - Sets the product data
    }
}
//------------------------------------------- END OF FILE ----------------------------------------------------------------------