using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class Stefferd3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ClientenId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58bcb787-c03b-4c0e-90f7-0b8209e876ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "675dfcf1-8578-4248-8e43-3e0931de077f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b81c9070-e5c4-489a-aeb4-0fbac0d1f956");

            migrationBuilder.RenameColumn(
                name: "ClientenId",
                table: "AspNetUsers",
                newName: "BehandelaarId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_ClientenId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_BehandelaarId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9092694a-5542-40d9-a1d4-1da87b54bd51", "fd13a7b7-f41f-473a-ac22-9eaa190b0c64", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89fc09c5-16ef-4908-bc8d-fbd73944ccc4", "e1b2de1e-6f41-4437-842d-8ff326222f58", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "808b7fe6-f84b-4ce5-9488-239e2731164d", "d1cd977a-ae81-4e32-aa17-d928bb741946", "Moderator", "MODERATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_BehandelaarId",
                table: "AspNetUsers",
                column: "BehandelaarId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_BehandelaarId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "808b7fe6-f84b-4ce5-9488-239e2731164d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89fc09c5-16ef-4908-bc8d-fbd73944ccc4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9092694a-5542-40d9-a1d4-1da87b54bd51");

            migrationBuilder.RenameColumn(
                name: "BehandelaarId",
                table: "AspNetUsers",
                newName: "ClientenId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_BehandelaarId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_ClientenId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b81c9070-e5c4-489a-aeb4-0fbac0d1f956", "b465c794-50ef-42cb-bdc4-c72a3777ec68", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58bcb787-c03b-4c0e-90f7-0b8209e876ca", "45673fa3-5a51-4bde-b63d-455d3fca7c8e", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "675dfcf1-8578-4248-8e43-3e0931de077f", "9a5862cd-3fb6-4000-a23e-9eb405efd06e", "Moderator", "MODERATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ClientenId",
                table: "AspNetUsers",
                column: "ClientenId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
