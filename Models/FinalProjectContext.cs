using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class FinalProjectContext : DbContext
    {
        public FinalProjectContext (DbContextOptions<FinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Final_Project.Models.Review> Category {get; set;}
        public DbSet<Final_Project.Models.Recipe> Movie { get; set; }
        public DbSet<Final_Project.Models.Review> Review {get; set;}
    }
}