using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class ZelfhulpLeeftijd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7440d68-8fee-469a-9a7d-3c06aaa92fa1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e006ee41-1a4d-45bf-a0e0-c85d5a3a5d28");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Zelfhulpgroepen",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "avgLeeftijd",
                table: "Zelfhulpgroepen",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9cd7f083-4ea9-477a-b2f0-4f379737a703", "498259f6-2e5a-4baf-a062-046cc312cbc8", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "765e16da-605a-4bf2-93da-0faf400b7c4c", "aed63ad1-9376-4fc2-9e30-fff80896a0ff", "Client", "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "765e16da-605a-4bf2-93da-0faf400b7c4c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd7f083-4ea9-477a-b2f0-4f379737a703");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Zelfhulpgroepen");

            migrationBuilder.DropColumn(
                name: "avgLeeftijd",
                table: "Zelfhulpgroepen");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e006ee41-1a4d-45bf-a0e0-c85d5a3a5d28", "9c56f281-7f5b-4bb8-8ee9-2bfec8b123fe", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d7440d68-8fee-469a-9a7d-3c06aaa92fa1", "41a5516b-5a65-4ce4-a3c0-919ab1c8363a", "Client", "Client" });
        }
    }
}
