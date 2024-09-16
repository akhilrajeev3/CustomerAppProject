using Microsoft.EntityFrameworkCore;
using CustomerBlazorApp.Models;

namespace CustomerBlazorApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Use the fully qualified name to avoid ambiguity if necessary
        public DbSet<CustomerBlazorApp.Models.Customer> Customer { get; set; }
    }
}
