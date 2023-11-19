using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WalkUniq.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newProductsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Company", "Description", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 9, 2, "Nike", "Nike Blazer Mid Premium Kadın Bej Spor Ayakkabı", "", 88.0, 85.0, 77.0, 80.0, "Nike" },
                    { 10, 2, "Vans", "Vans Sk8-HI Platform 2.0 Siyah Kadın Sneaker", "", 95.0, 90.0, 86.0, 88.0, "Vans" },
                    { 11, 2, "adidas", "adidas Falcon Kadın Siyah Spor Ayakkabı", "", 95.0, 90.0, 86.0, 88.0, "adidas" },
                    { 12, 2, "Puma", "Puma Mayze Kadın Siyah Spor Ayakkabı", "", 110.0, 108.0, 100.0, 105.0, "Puma" },
                    { 13, 2, "Puma", "Puma Mayze Kadın Platform Bej Spor Ayakkabı", "", 110.0, 108.0, 100.0, 105.0, "Puma" },
                    { 14, 2, "Tommy Jeans", "Tommy Jeans Retro Basket Kadın Beyaz Sneaker", "", 150.0, 140.0, 130.0, 138.0, "Tommy Jeans" },
                    { 15, 2, "Puma", "Puma Mayze Kadın Beyaz Spor Ayakkabı", "", 100.0, 98.0, 95.0, 96.0, "Puma" },
                    { 16, 2, "Puma", "Puma RS-X Reinvention Kadın Krem Spor Ayakkabı", "", 110.0, 94.0, 85.0, 91.0, "Puma" },
                    { 17, 2, "adidas", "adidas Forum Bold Kadın Beyaz Spor Ayakkabı", "", 170.0, 114.0, 95.0, 111.0, "adidas" },
                    { 18, 2, "Puma", "Puma Mayze Kadın Mor Spor Ayakkabı", "", 100.0, 96.0, 85.0, 90.0, "Puma" },
                    { 19, 1, "adidas", "adidas Response Cl Kahverengi Spor Ayakkabı", "", 100.0, 96.0, 85.0, 90.0, "adidas" },
                    { 20, 1, "Nike", "Nike Air Vapormax 2023 Flyknit Erkek Mavi Spor Ayakkabı", "", 220.0, 200.0, 170.0, 180.0, "Nike" },
                    { 21, 1, "Nike", "Nike Air Max 97 Erkek Gri Spor Ayakkabı", "", 218.0, 200.0, 170.0, 180.0, "Nike" },
                    { 22, 1, "adidas", "adidas Superstar Erkek Beyaz Spor Ayakkabı", "", 170.0, 165.0, 150.0, 160.0, "adidas" },
                    { 23, 1, "adidas", "adidas Adifom Superstar Erkek Haki Spor Ayakkabı", "", 150.0, 140.0, 120.0, 130.0, "adidas" },
                    { 24, 1, "Puma", "Puma BMW MMS Maco Erkek Beyaz Spor Ayakkabı", "", 260.0, 250.0, 180.0, 200.0, "Puma" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);
        }
    }
}
