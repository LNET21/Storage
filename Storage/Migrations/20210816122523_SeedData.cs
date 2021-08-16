using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Count", "Description", "Name", "OrderDate", "Price", "Shelf" },
                values: new object[,]
                {
                    { 1, "Mobile", 156, "Beskrivning av telefonen här", "Iphone 12", new DateTime(2021, 8, 10, 14, 25, 22, 905, DateTimeKind.Local).AddTicks(5154), 15600, "4B" },
                    { 2, "Mobile", 98, "Beskrivning av telefonen här", "S20", new DateTime(2021, 7, 24, 14, 25, 22, 908, DateTimeKind.Local).AddTicks(591), 12450, "4C" },
                    { 3, "Computers", 23, "Beskrivning här", "MacBook", new DateTime(2021, 8, 11, 14, 25, 22, 908, DateTimeKind.Local).AddTicks(635), 45600, "4C" },
                    { 4, "Computer", 32, "Beskrivning här", "Suface X", new DateTime(2021, 7, 7, 14, 25, 22, 908, DateTimeKind.Local).AddTicks(639), 26850, "5C" },
                    { 5, "Office Supplies", 15651, "Beskrivning här", "Pen", new DateTime(2021, 8, 10, 14, 25, 22, 908, DateTimeKind.Local).AddTicks(642), 1, "45W" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
