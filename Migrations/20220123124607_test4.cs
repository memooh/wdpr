using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "659d1fa2-4235-4a11-89f4-f41786a08856");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7afea1e-d4f2-47f3-932d-489d3d342bf7");

            migrationBuilder.AddColumn<bool>(
                name: "VoogdToestemming",
                table: "Aanmeldingen",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c137188c-7601-4e22-b5ba-99a880225b64", "7cd851a5-72dd-4bdf-867d-01f2f36f2588", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "493a03ce-c9b9-47d8-875d-377611e5f688", "2a08c607-8ad8-4f19-9a1d-a78eae6f2a46", "Client", "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "493a03ce-c9b9-47d8-875d-377611e5f688");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c137188c-7601-4e22-b5ba-99a880225b64");

            migrationBuilder.DropColumn(
                name: "VoogdToestemming",
                table: "Aanmeldingen");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e7afea1e-d4f2-47f3-932d-489d3d342bf7", "53d63b94-fbec-4af1-a0ed-44855ddbf928", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "659d1fa2-4235-4a11-89f4-f41786a08856", "a343d0e9-af06-4f88-9b11-d3fde997b12f", "Client", "Client" });
        }
    }
}
