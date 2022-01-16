using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class yolowaterpolotest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46688ee5-d068-4b26-829e-06bcfb0ce221", "d043e171-c6bf-47e7-a64d-07b7e42db8d3", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd22265e-8678-4d8b-8589-07445af68620", "23dcc76d-a994-42eb-a51c-a7c8e441e1e6", "Patient", "PATIENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46688ee5-d068-4b26-829e-06bcfb0ce221");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd22265e-8678-4d8b-8589-07445af68620");
        }
    }
}
