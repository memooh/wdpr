using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class objecteditf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4814b840-25b8-4789-8c94-895e18d1b2cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8abdfc9a-f141-4f99-af36-bd0284eaf06b");

            migrationBuilder.AddColumn<string>(
                name: "BehandelaarId",
                table: "Aanmeldingen",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b62421c0-d5b1-4d70-a9a9-381fbb77c7da", "2d6fbd48-137e-41e3-9d1c-23f5bfde61d2", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "356d48ef-8f41-4903-93b7-19c0aaa5d1d9", "51f9c5c5-67fe-4924-a1ce-e0b8800d9dfb", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_Aanmeldingen_BehandelaarId",
                table: "Aanmeldingen",
                column: "BehandelaarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aanmeldingen_AspNetUsers_BehandelaarId",
                table: "Aanmeldingen",
                column: "BehandelaarId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aanmeldingen_AspNetUsers_BehandelaarId",
                table: "Aanmeldingen");

            migrationBuilder.DropIndex(
                name: "IX_Aanmeldingen_BehandelaarId",
                table: "Aanmeldingen");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "356d48ef-8f41-4903-93b7-19c0aaa5d1d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b62421c0-d5b1-4d70-a9a9-381fbb77c7da");

            migrationBuilder.DropColumn(
                name: "BehandelaarId",
                table: "Aanmeldingen");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8abdfc9a-f141-4f99-af36-bd0284eaf06b", "35aa2be3-7033-4483-9846-44092f55194e", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4814b840-25b8-4789-8c94-895e18d1b2cf", "ea8b6d39-f0de-43a6-bd94-b4dd69ef08dc", "Client", "Client" });
        }
    }
}
