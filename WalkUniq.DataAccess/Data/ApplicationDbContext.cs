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
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //line and that is because keys of identity tables are mapped in the on model creating.
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name="Man" ,DisplayOrder=1},
                new Category { Id = 2, Name="Women" ,DisplayOrder=2},
                new Category { Id = 3, Name="Children" ,DisplayOrder=3}
                );
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Shoes Solution",
                    StreetAddress = "123 Tech St",
                    City = "Tech City",
                    PostalCode = "12121",
                    State = "IL",
                    PhoneNumber = "6669990000"
                },
                new Company
                {
                    Id = 2,
                    Name = "Vivid Run",
                    StreetAddress = "999 Vid St",
                    City = "Vid City",
                    PostalCode = "66666",
                    State = "IL",
                    PhoneNumber = "7779990000"
                },
                new Company
                {
                    Id = 3,
                    Name = "Barcin Club",
                    StreetAddress = "999 Main St",
                    City = "Lala land",
                    PostalCode = "99999",
                    State = "NY",
                    PhoneNumber = "1113335555"
                }
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
                },
                 new Product
                 {
                     Id = 7,
                     Title = "Vans",
                     Company = "adidas",
                     Description = "adidas Oznova Erkek Siyah Spor Ayakkabı ",
                     ListPrice = 66,
                     Price = 60,
                     Price50 = 58,
                     Price100 = 54,
                     CategoryId = 2,
                     ImageUrl = "\"C:\\Users\\90535\\Desktop\\images for site\\shoes image\\adidas Oznova Erkek Siyah Spor Ayakkabı.webp\""
                 },
                  new Product
                  {
                      Id = 8,
                      Title = "adidas",
                      Company = "adidas",
                      Description = "adidas Oznova Erkek Beyaz Spor Ayakkabı ",
                      ListPrice = 66,
                      Price = 60,
                      Price50 = 58,
                      Price100 = 54,
                      CategoryId = 2,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 9,
                      Title = "Nike",
                      Company = "Nike",
                      Description = "Nike Blazer Mid Premium Kadın Bej Spor Ayakkabı",
                      ListPrice = 88,
                      Price = 85,
                      Price50 = 80,
                      Price100 = 77,
                      CategoryId = 2,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 10,
                      Title = "Vans",
                      Company = "Vans",
                      Description = "Vans Sk8-HI Platform 2.0 Siyah Kadın Sneaker",
                      ListPrice = 95,
                      Price = 90,
                      Price50 = 88,
                      Price100 = 86,
                      CategoryId = 2,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 11,
                      Title = "adidas",
                      Company = "adidas",
                      Description = "adidas Falcon Kadın Siyah Spor Ayakkabı",
                      ListPrice = 95,
                      Price = 90,
                      Price50 = 88,
                      Price100 = 86,
                      CategoryId = 2,
                      ImageUrl = ""
                  }
                  ,
                  new Product
                  {
                      Id = 12,
                      Title = "Puma",
                      Company = "Puma",
                      Description = "Puma Mayze Kadın Siyah Spor Ayakkabı",
                      ListPrice = 110,
                      Price = 108,
                      Price50 = 105,
                      Price100 = 100,
                      CategoryId = 2,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 13,
                      Title = "Puma",
                      Company = "Puma",
                      Description = "Puma Mayze Kadın Platform Bej Spor Ayakkabı",
                      ListPrice = 110,
                      Price = 108,
                      Price50 = 105,
                      Price100 = 100,
                      CategoryId = 2,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 14,
                      Title = "Tommy Jeans",
                      Company = "Tommy Jeans",
                      Description = "Tommy Jeans Retro Basket Kadın Beyaz Sneaker",
                      ListPrice = 150,
                      Price = 140,
                      Price50 = 138,
                      Price100 = 130,
                      CategoryId = 2,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 15,
                      Title = "Puma",
                      Company = "Puma",
                      Description = "Puma Mayze Kadın Beyaz Spor Ayakkabı",
                      ListPrice = 100,
                      Price = 98,
                      Price50 = 96,
                      Price100 = 95,
                      CategoryId = 2,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 16,
                      Title = "Puma",
                      Company = "Puma",
                      Description = "Puma RS-X Reinvention Kadın Krem Spor Ayakkabı",
                      ListPrice = 110,
                      Price = 94,
                      Price50 = 91,
                      Price100 = 85,
                      CategoryId = 2,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 17,
                      Title = "adidas",
                      Company = "adidas",
                      Description = "adidas Forum Bold Kadın Beyaz Spor Ayakkabı",
                      ListPrice = 170,
                      Price = 114,
                      Price50 = 111,
                      Price100 = 95,
                      CategoryId = 2,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 18,
                      Title = "Puma",
                      Company = "Puma",
                      Description = "Puma Mayze Kadın Mor Spor Ayakkabı",
                      ListPrice = 100,
                      Price = 96,
                      Price50 = 90,
                      Price100 = 85,
                      CategoryId = 2,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 19,
                      Title = "adidas",
                      Company = "adidas",
                      Description = "adidas Response Cl Kahverengi Spor Ayakkabı",
                      ListPrice = 100,
                      Price = 96,
                      Price50 = 90,
                      Price100 = 85,
                      CategoryId = 1,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 20,
                      Title = "Nike",
                      Company = "Nike",
                      Description = "Nike Air Vapormax 2023 Flyknit Erkek Mavi Spor Ayakkabı",
                      ListPrice = 220,
                      Price = 200,
                      Price50 = 180,
                      Price100 = 170,
                      CategoryId = 1,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 21,
                      Title = "Nike",
                      Company = "Nike",
                      Description = "Nike Air Max 97 Erkek Gri Spor Ayakkabı",
                      ListPrice = 218,
                      Price = 200,
                      Price50 = 180,
                      Price100 = 170,
                      CategoryId = 1,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 22,
                      Title = "adidas",
                      Company = "adidas",
                      Description = "adidas Superstar Erkek Beyaz Spor Ayakkabı",
                      ListPrice = 170,
                      Price = 165,
                      Price50 = 160,
                      Price100 = 150,
                      CategoryId = 1,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 23,
                      Title = "adidas",
                      Company = "adidas",
                      Description = "adidas Adifom Superstar Erkek Haki Spor Ayakkabı",
                      ListPrice = 150,
                      Price = 140,
                      Price50 = 130,
                      Price100 = 120,
                      CategoryId = 1,
                      ImageUrl = ""
                  },
                  new Product
                  {
                      Id = 24,
                      Title = "Puma",
                      Company = "Puma",
                      Description = "Puma BMW MMS Maco Erkek Beyaz Spor Ayakkabı",
                      ListPrice = 260,
                      Price = 250,
                      Price50 = 200,
                      Price100 = 180,
                      CategoryId = 1,
                      ImageUrl = ""
                  }





                );
        }
    }

}
