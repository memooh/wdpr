using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class LatestChangese : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25133e77-d954-41ad-a7d7-ce9698c1ecbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8f6bd2e-60eb-4042-8113-ed3351760cda");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87e80e0f-b2b3-4721-b504-1ccce6d82621", "82dbc071-7d77-4dc8-98e2-7c9b33171963", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed86c7db-cca1-49bf-97f2-aa7b5d89b7ee", "0fa5ca01-e87f-474b-8b75-90abb4c1ef59", "Client", "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87e80e0f-b2b3-4721-b504-1ccce6d82621");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed86c7db-cca1-49bf-97f2-aa7b5d89b7ee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "25133e77-d954-41ad-a7d7-ce9698c1ecbc", "8d2b0549-fd9d-4b28-abf5-50042ccf874b", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8f6bd2e-60eb-4042-8113-ed3351760cda", "64ed8011-ec31-4cbb-a0f7-fd1bcbf7ea14", "Client", "Client" });
        }
    }
}
