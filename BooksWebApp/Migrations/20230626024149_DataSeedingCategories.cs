using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksWebApp.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedingCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CreatedDateTime", "DisplayOrder", "Name" },
                values: new object[] { 1, new DateTime(2023, 6, 26, 4, 41, 49, 500, DateTimeKind.Local).AddTicks(6719), 50, "Category 1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);
        }
    }
}
