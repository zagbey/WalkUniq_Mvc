using Microsoft.EntityFrameworkCore;

namespace WalkUniq.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options) 
        {
            
        }
    }
}
