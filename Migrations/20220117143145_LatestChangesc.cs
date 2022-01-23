using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class LatestChangesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72fb7f3a-fd21-4314-a8c0-dcfddc2444aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "768f06ad-1152-4837-9080-dd1f2b0fdf38");

            migrationBuilder.AddColumn<bool>(
                name: "IsZelfHulpGroep",
                table: "Chats",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e8b0b38a-da4e-4096-a56e-40ba39deb66a", "3145c4e3-4aa4-44b8-ba04-ac1364067228", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba686226-f69e-47fc-8d4d-63b0ae62018e", "e07423ee-a694-496f-9ad3-986a7b7c3a29", "Client", "Client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba686226-f69e-47fc-8d4d-63b0ae62018e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8b0b38a-da4e-4096-a56e-40ba39deb66a");

            migrationBuilder.DropColumn(
                name: "IsZelfHulpGroep",
                table: "Chats");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "768f06ad-1152-4837-9080-dd1f2b0fdf38", "26057391-3354-4c49-bd99-c6f896d3aa72", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72fb7f3a-fd21-4314-a8c0-dcfddc2444aa", "0a7c1cba-91ae-40ca-9b80-6e8bd1d9d9ca", "Client", "Client" });
        }
    }
}
