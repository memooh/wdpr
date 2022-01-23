using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class RelationSolved1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "5dd846a4-7692-414d-8789-885268601aec", "d28f05ab-1c02-4a38-aa6c-99cdf40cc994", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4339221-ad96-471e-907f-63307b2ba612", "b3ea2385-ed83-4349-8c69-1195cd445f99", "Client", "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd846a4-7692-414d-8789-885268601aec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4339221-ad96-471e-907f-63307b2ba612");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00a83997-d194-4312-9739-3d635cb7d2b2", "144081ff-55e7-4d20-9e5a-c5369038b293", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d52a08d-d338-4613-9b2f-e62a5bc3ac6f", "523fa515-52e6-499f-9c3c-39dd979dc45c", "Client", "Client" });
        }
    }
}
