using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WalkUniq.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addDbChangedToSQLITE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Company = table.Column<string>(type: "TEXT", nullable: false),
                    ListPrice = table.Column<double>(type: "REAL", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Price50 = table.Column<double>(type: "REAL", nullable: false),
                    Price100 = table.Column<double>(type: "REAL", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Man" },
                    { 2, 2, "Women" },
                    { 3, 3, "Children" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Company", "Description", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Converse", "Converse Chuck 70 Hi Unisex Siyah Sneaker", "", 99.0, 90.0, 80.0, 85.0, "Converse" },
                    { 2, 1, "Converse", "Converse Chuck Taylor All Star Unisex Siyah Sneaker ", "", 40.0, 30.0, 20.0, 25.0, "Converse" },
                    { 3, 1, "Nike", "Nike Waffle One Erkek Bej Spor Ayakkabı ", "", 55.0, 50.0, 35.0, 40.0, "Nike" },
                    { 4, 1, "adidas", "adidas Ozweego Unisex Beyaz Spor Ayakkabı", "", 70.0, 65.0, 55.0, 60.0, "adidas" },
                    { 5, 2, "Converse", "Converse Run Star Hike Platform Unisex Siyah Sneaker ", "", 30.0, 27.0, 20.0, 25.0, "Converse" },
                    { 6, 2, "Vans", "Vans Old Skool Unisex Siyah Sneaker ", "", 25.0, 23.0, 20.0, 22.0, "Vans" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
