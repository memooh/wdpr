using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "493a03ce-c9b9-47d8-875d-377611e5f688");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c137188c-7601-4e22-b5ba-99a880225b64");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f21ad9e-f89e-4d97-868e-13fe9924f526", "8bbf8e0c-391c-4a9e-8722-3ab69c20a78d", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4dcb58d5-a79e-4fcb-a9a1-83b4c881058b", "58ba0bc6-e82a-42b8-a227-99476a9b006b", "Client", "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c137188c-7601-4e22-b5ba-99a880225b64", "7cd851a5-72dd-4bdf-867d-01f2f36f2588", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "493a03ce-c9b9-47d8-875d-377611e5f688", "2a08c607-8ad8-4f19-9a1d-a78eae6f2a46", "Client", "Client" });
        }
    }
}
