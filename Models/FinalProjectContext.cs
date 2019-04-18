using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class FinalProjectContext : DbContext
    {
        public FinalProjectContext (DbContextOptions<FinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Final_Project.Models.Category> Category {get; set;}
        public DbSet<Final_Project.Models.Recipe> Recipe { get; set; }
        public DbSet<Final_Project.Models.Review> Review {get; set;}
    }
}