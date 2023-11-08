using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using WalkUniq.Models;
using Microsoft.AspNetCore.Identity;

namespace WalkUniq.DataAccess.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //line and that is because keys of identity tables are mapped in the on model creating.
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name="Man" ,DisplayOrder=1},
                new Category { Id = 2, Name="Women" ,DisplayOrder=2},
                new Category { Id = 3, Name="Children" ,DisplayOrder=3}
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Converse",
                    Company = "Converse",
                    Description = "Converse Chuck 70 Hi Unisex Siyah Sneaker",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl=""
                    
                },
                new Product
                {
                    Id = 2,
                    Title = "Converse",
                    Company = "Converse",
                    Description = "Converse Chuck Taylor All Star Unisex Siyah Sneaker ",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 1,
                   ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "Nike",
                    Company = "Nike",
                    Description = "Nike Waffle One Erkek Bej Spor Ayakkabı ",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "adidas",
                    Company = "adidas",
                    Description = "adidas Ozweego Unisex Beyaz Spor Ayakkabı",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                 new Product
                 {
                     Id = 5,
                     Title = "Converse",
                     Company = "Converse",
                     Description = "Converse Run Star Hike Platform Unisex Siyah Sneaker ",
                     ListPrice = 30,
                     Price = 27,
                     Price50 = 25,
                     Price100 = 20,
                     CategoryId = 2,
                     ImageUrl = ""
                 },
                new Product
                {
                    Id = 6,
                    Title = "Vans",
                    Company = "Vans",
                    Description = "Vans Old Skool Unisex Siyah Sneaker ",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl=""
                }

                );
        }
    }

}
