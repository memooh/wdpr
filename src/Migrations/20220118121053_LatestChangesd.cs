using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class LatestChangesd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ZelfhulpgroepId",
                table: "Chats",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "25133e77-d954-41ad-a7d7-ce9698c1ecbc", "8d2b0549-fd9d-4b28-abf5-50042ccf874b", "Voogd", "Voogd" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8f6bd2e-60eb-4042-8113-ed3351760cda", "64ed8011-ec31-4cbb-a0f7-fd1bcbf7ea14", "Client", "Client" });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ZelfhulpgroepId",
                table: "Chats",
                column: "ZelfhulpgroepId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Zelfhulpgroepen_ZelfhulpgroepId",
                table: "Chats",
                column: "ZelfhulpgroepId",
                principalTable: "Zelfhulpgroepen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Zelfhulpgroepen_ZelfhulpgroepId",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Chats_ZelfhulpgroepId",
                table: "Chats");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25133e77-d954-41ad-a7d7-ce9698c1ecbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8f6bd2e-60eb-4042-8113-ed3351760cda");

            migrationBuilder.DropColumn(
                name: "ZelfhulpgroepId",
                table: "Chats");

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
    }
}
