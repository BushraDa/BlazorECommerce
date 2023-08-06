using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorECommerce.Server.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "Description", "Name", "Price" },
                values: new object[] { new Guid("8801a399-3d4a-4806-bde9-f4ad65b27dc5"), "", "Embroidery", 2000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "Description", "Name", "Price" },
                values: new object[] { new Guid("d226ec89-6275-43a0-8691-9bbec32788e1"), "", "Painting", 1000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: new Guid("8801a399-3d4a-4806-bde9-f4ad65b27dc5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: new Guid("d226ec89-6275-43a0-8691-9bbec32788e1"));
        }
    }
}
