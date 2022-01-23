using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class objectedite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dd5d6d6-21e0-4a9e-b375-e15570af77b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc565951-c101-429c-9595-77c28c406701");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8abdfc9a-f141-4f99-af36-bd0284eaf06b", "35aa2be3-7033-4483-9846-44092f55194e", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4814b840-25b8-4789-8c94-895e18d1b2cf", "ea8b6d39-f0de-43a6-bd94-b4dd69ef08dc", "Client", "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4814b840-25b8-4789-8c94-895e18d1b2cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8abdfc9a-f141-4f99-af36-bd0284eaf06b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7dd5d6d6-21e0-4a9e-b375-e15570af77b3", "3af50a51-f39c-4f08-ae93-0f31a4a033d5", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc565951-c101-429c-9595-77c28c406701", "79085c40-1294-4ea3-9bca-a4a6e1a225d4", "Client", "Client" });
        }
    }
}
