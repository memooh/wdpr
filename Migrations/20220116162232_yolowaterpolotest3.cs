using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class yolowaterpolotest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46688ee5-d068-4b26-829e-06bcfb0ce221");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd22265e-8678-4d8b-8589-07445af68620");

            migrationBuilder.AddColumn<int>(
                name: "avgLeeftijd",
                table: "Zelfhulpgroepen",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b561d3b-9c3d-4cad-a622-8dfa72901017", "37ee5d68-b25a-48d7-8885-61aa696c4a24", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f64f0624-53f9-466e-8430-ebde265edef9", "71af6191-43b2-429f-87c7-5e3d8d1d296f", "Patient", "PATIENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b561d3b-9c3d-4cad-a622-8dfa72901017");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f64f0624-53f9-466e-8430-ebde265edef9");

            migrationBuilder.DropColumn(
                name: "avgLeeftijd",
                table: "Zelfhulpgroepen");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46688ee5-d068-4b26-829e-06bcfb0ce221", "d043e171-c6bf-47e7-a64d-07b7e42db8d3", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd22265e-8678-4d8b-8589-07445af68620", "23dcc76d-a994-42eb-a51c-a7c8e441e1e6", "Patient", "PATIENT" });
        }
    }
}
