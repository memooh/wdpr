using Microsoft.EntityFrameworkCore.Migrations;

namespace wdpr.Migrations
{
    public partial class Stefferd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BehandelaarsClienten_BehandelaarsClientenId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BehandelaarsClienten");

            migrationBuilder.DropTable(
                name: "Behandelaren");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BehandelaarsClientenId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e48c56e-4b0e-4514-bc70-ac5a8be843ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2b52860-91d1-4469-9f10-e87b82a13d2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8716eaf-6468-490d-8274-2ae690c874a9");

            migrationBuilder.DropColumn(
                name: "BehandelaarId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BehandelaarsClientenId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ClientenId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClientenId",
                table: "AspNetUsers",
                column: "ClientenId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ClientenId",
                table: "AspNetUsers",
                column: "ClientenId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ClientenId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClientenId",
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

            migrationBuilder.DropColumn(
                name: "ClientenId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "BehandelaarId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BehandelaarsClientenId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Behandelaren",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BehandelaarsClientenId = table.Column<int>(type: "INTEGER", nullable: false),
                    GebruikerId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Behandelaren", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Behandelaren_AspNetUsers_GebruikerId",
                        column: x => x.GebruikerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BehandelaarsClienten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BehandelaarId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BehandelaarsClienten", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BehandelaarsClienten_Behandelaren_BehandelaarId",
                        column: x => x.BehandelaarId,
                        principalTable: "Behandelaren",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8716eaf-6468-490d-8274-2ae690c874a9", "79c89d04-5397-445d-a5a5-a011d10f5559", "Hulpverlener", "HULPVERLENER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2b52860-91d1-4469-9f10-e87b82a13d2e", "413ea522-84b3-4c67-bef7-8f6bac21f7d1", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e48c56e-4b0e-4514-bc70-ac5a8be843ea", "368bfed2-08a4-4ff0-8127-e17bd13a8977", "Moderator", "MODERATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BehandelaarsClientenId",
                table: "AspNetUsers",
                column: "BehandelaarsClientenId");

            migrationBuilder.CreateIndex(
                name: "IX_BehandelaarsClienten_BehandelaarId",
                table: "BehandelaarsClienten",
                column: "BehandelaarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Behandelaren_GebruikerId",
                table: "Behandelaren",
                column: "GebruikerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BehandelaarsClienten_BehandelaarsClientenId",
                table: "AspNetUsers",
                column: "BehandelaarsClientenId",
                principalTable: "BehandelaarsClienten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
