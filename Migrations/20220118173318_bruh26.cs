using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class bruh26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "124765a1-b107-4b69-bb9a-3ece79cf3921");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6beec4fe-491f-448f-a848-f5d9669b98fe");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a10636b-4289-41fb-9e15-0ccc77dd39b1", "2f9d0937-c7d6-4488-8939-3420229b06fc", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c6a03ab4-0961-468e-9412-038c6c9f8637", "a021ea4d-d3ce-4afa-911e-4ee78fbeb63b", "Patient", "PATIENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a10636b-4289-41fb-9e15-0ccc77dd39b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a03ab4-0961-468e-9412-038c6c9f8637");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6beec4fe-491f-448f-a848-f5d9669b98fe", "7bb65136-4d1d-4df8-bcdc-11a4c093acdf", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "124765a1-b107-4b69-bb9a-3ece79cf3921", "2a44ac75-04d6-44df-965b-c18ba13862e4", "Patient", "PATIENT" });
        }
    }
}
