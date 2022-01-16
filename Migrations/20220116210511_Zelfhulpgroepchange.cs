using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class Zelfhulpgroepchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b561d3b-9c3d-4cad-a622-8dfa72901017");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f64f0624-53f9-466e-8430-ebde265edef9");

            migrationBuilder.AlterColumn<string>(
                name: "avgLeeftijd",
                table: "Zelfhulpgroepen",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c90947b3-36e8-425c-81f5-5c4aa35a0f8e", "feb69325-624e-41e8-ab0d-964e781b382c", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "21f3d531-268c-4973-9c0c-690cf493b95d", "55384ab9-d710-439e-85cc-4426a5c0d62b", "Patient", "PATIENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21f3d531-268c-4973-9c0c-690cf493b95d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c90947b3-36e8-425c-81f5-5c4aa35a0f8e");

            migrationBuilder.AlterColumn<int>(
                name: "avgLeeftijd",
                table: "Zelfhulpgroepen",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b561d3b-9c3d-4cad-a622-8dfa72901017", "37ee5d68-b25a-48d7-8885-61aa696c4a24", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f64f0624-53f9-466e-8430-ebde265edef9", "71af6191-43b2-429f-87c7-5e3d8d1d296f", "Patient", "PATIENT" });
        }
    }
}
