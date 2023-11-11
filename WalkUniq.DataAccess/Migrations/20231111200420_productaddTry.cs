﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WalkUniq.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class productaddTry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Company", "Description", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 7, 2, "adidas", "adidas Oznova Erkek Siyah Spor Ayakkabı ", "", 66.0, 60.0, 54.0, 58.0, "Vans" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
