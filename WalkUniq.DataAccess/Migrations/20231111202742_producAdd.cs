using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WalkUniq.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class producAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Company", "Description", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 8, 2, "adidas", "adidas Oznova Erkek Beyaz Spor Ayakkabı ", "", 66.0, 60.0, 54.0, 58.0, "adidas" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
