using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class RelationSolved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c184448-e5d4-46e0-a5d9-c67dd6ddabd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c9413b7-f8c9-4932-869f-424be7022bcc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00a83997-d194-4312-9739-3d635cb7d2b2", "144081ff-55e7-4d20-9e5a-c5369038b293", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d52a08d-d338-4613-9b2f-e62a5bc3ac6f", "523fa515-52e6-499f-9c3c-39dd979dc45c", "Client", "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00a83997-d194-4312-9739-3d635cb7d2b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d52a08d-d338-4613-9b2f-e62a5bc3ac6f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6c9413b7-f8c9-4932-869f-424be7022bcc", "2afd2a40-2f62-4856-953d-4443756fab48", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c184448-e5d4-46e0-a5d9-c67dd6ddabd3", "d057ed99-f7a0-422a-aa04-570042101da9", "Client", "Client" });
        }
    }
}
