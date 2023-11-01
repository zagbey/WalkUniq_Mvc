using Microsoft.EntityFrameworkCore;
using WalkUniq.Models;

namespace WalkUniq.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
