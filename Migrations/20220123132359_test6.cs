using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f21ad9e-f89e-4d97-868e-13fe9924f526");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dcb58d5-a79e-4fcb-a9a1-83b4c881058b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a883fbd0-35f2-4079-98e5-96ccb9a9297c", "9aeb695c-7e80-4eba-87f9-2f4f8b64f272", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0835d9f2-db87-4c2c-9d06-611f0ed39310", "076e2319-3864-4bff-949b-372402dcf121", "Client", "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0835d9f2-db87-4c2c-9d06-611f0ed39310");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a883fbd0-35f2-4079-98e5-96ccb9a9297c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f21ad9e-f89e-4d97-868e-13fe9924f526", "8bbf8e0c-391c-4a9e-8722-3ab69c20a78d", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4dcb58d5-a79e-4fcb-a9a1-83b4c881058b", "58ba0bc6-e82a-42b8-a227-99476a9b006b", "Client", "Client" });
        }
    }
}
