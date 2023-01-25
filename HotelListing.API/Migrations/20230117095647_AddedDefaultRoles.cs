using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ccc776e-8f06-42b7-aca0-ac79c1460fcf", "5caa4618-9378-4cd7-be0e-7c78ec3acfc6", "Administrator", "ADMINISTRATOR" },
                    { "e059d04e-50a1-44a1-93d9-5e8f0cde4e06", "2a787260-11d9-4ec0-a128-210200c03486", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ccc776e-8f06-42b7-aca0-ac79c1460fcf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e059d04e-50a1-44a1-93d9-5e8f0cde4e06");
        }
    }
}
