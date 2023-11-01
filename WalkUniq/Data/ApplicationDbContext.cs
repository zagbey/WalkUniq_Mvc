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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name="Man" ,DisplayOrder=1},
                new Category { Id = 2, Name="Women" ,DisplayOrder=2},
                new Category { Id = 3, Name="Children" ,DisplayOrder=3}
                );
        }
    }

}
