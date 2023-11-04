using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WalkUniq.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Company", "Description", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Converse", "Converse Chuck 70 Hi Unisex Siyah Sneaker", 99.0, 90.0, 80.0, 85.0, "Converse" },
                    { 2, "Converse", "Converse Chuck Taylor All Star Unisex Siyah Sneaker ", 40.0, 30.0, 20.0, 25.0, "Converse" },
                    { 3, "Nike", "Nike Waffle One Erkek Bej Spor Ayakkabı ", 55.0, 50.0, 35.0, 40.0, "Nike" },
                    { 4, "adidas", "adidas Ozweego Unisex Beyaz Spor Ayakkabı", 70.0, 65.0, 55.0, 60.0, "adidas" },
                    { 5, "Converse", "Converse Run Star Hike Platform Unisex Siyah Sneaker ", 30.0, 27.0, 20.0, 25.0, "Converse" },
                    { 6, "Vans", "Vans Old Skool Unisex Siyah Sneaker ", 25.0, 23.0, 20.0, 22.0, "Vans" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
