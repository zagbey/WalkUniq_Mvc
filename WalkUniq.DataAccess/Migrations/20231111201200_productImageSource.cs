using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WalkUniq.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class productImageSource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "\"C:\\Users\\90535\\Desktop\\images for site\\shoes image\\adidas Oznova Erkek Siyah Spor Ayakkabı.webp\"");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "");
        }
    }
}
