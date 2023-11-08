﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WalkUniq.DataAccess.Data;

#nullable disable

namespace WalkUniq.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231108080850_addDbChangedToSQLITE")]
    partial class addDbChangedToSQLITE
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-rc.2.23480.1");

            modelBuilder.Entity("WalkUniq.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Man"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Women"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Children"
                        });
                });

            modelBuilder.Entity("WalkUniq.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("ListPrice")
                        .HasColumnType("REAL");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<double>("Price100")
                        .HasColumnType("REAL");

                    b.Property<double>("Price50")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Company = "Converse",
                            Description = "Converse Chuck 70 Hi Unisex Siyah Sneaker",
                            ImageUrl = "",
                            ListPrice = 99.0,
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Title = "Converse"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Company = "Converse",
                            Description = "Converse Chuck Taylor All Star Unisex Siyah Sneaker ",
                            ImageUrl = "",
                            ListPrice = 40.0,
                            Price = 30.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "Converse"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Company = "Nike",
                            Description = "Nike Waffle One Erkek Bej Spor Ayakkabı ",
                            ImageUrl = "",
                            ListPrice = 55.0,
                            Price = 50.0,
                            Price100 = 35.0,
                            Price50 = 40.0,
                            Title = "Nike"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Company = "adidas",
                            Description = "adidas Ozweego Unisex Beyaz Spor Ayakkabı",
                            ImageUrl = "",
                            ListPrice = 70.0,
                            Price = 65.0,
                            Price100 = 55.0,
                            Price50 = 60.0,
                            Title = "adidas"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Company = "Converse",
                            Description = "Converse Run Star Hike Platform Unisex Siyah Sneaker ",
                            ImageUrl = "",
                            ListPrice = 30.0,
                            Price = 27.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "Converse"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Company = "Vans",
                            Description = "Vans Old Skool Unisex Siyah Sneaker ",
                            ImageUrl = "",
                            ListPrice = 25.0,
                            Price = 23.0,
                            Price100 = 20.0,
                            Price50 = 22.0,
                            Title = "Vans"
                        });
                });

            modelBuilder.Entity("WalkUniq.Models.Product", b =>
                {
                    b.HasOne("WalkUniq.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}