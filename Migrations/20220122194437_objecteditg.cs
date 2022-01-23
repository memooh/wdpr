using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class objecteditg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "356d48ef-8f41-4903-93b7-19c0aaa5d1d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b62421c0-d5b1-4d70-a9a9-381fbb77c7da");

            migrationBuilder.AddColumn<bool>(
                name: "HeeftAccount",
                table: "Aanmeldingen",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "130d9d4a-fdab-4ad4-89e2-5213f4d91536", "3d72a1d6-dabd-4a81-9de1-bbc3ce51bf85", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99205cb7-55e3-4c8e-a07c-cc2b4f3f74ba", "b368e99c-e90a-42ea-ae68-32dc4dad7c16", "Client", "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "130d9d4a-fdab-4ad4-89e2-5213f4d91536");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99205cb7-55e3-4c8e-a07c-cc2b4f3f74ba");

            migrationBuilder.DropColumn(
                name: "HeeftAccount",
                table: "Aanmeldingen");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b62421c0-d5b1-4d70-a9a9-381fbb77c7da", "2d6fbd48-137e-41e3-9d1c-23f5bfde61d2", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "356d48ef-8f41-4903-93b7-19c0aaa5d1d9", "51f9c5c5-67fe-4924-a1ce-e0b8800d9dfb", "Client", "Client" });
        }
    }
}
